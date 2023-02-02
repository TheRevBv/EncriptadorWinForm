using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Encriptador
{
    public partial class Encripter : Form
    {
        int caso;

        public Encripter()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                cleanRes();
                seleccionCaso();
                string encriptado = "";

                switch (caso)
                {
                    case 0:
                        encriptado = EncriptarAscii(inputMsj1.Text, getClave(inputClave1.Text).Sum());
                        break;
                    case 1:
                        encriptado = EncriptarAes(inputMsj2.Text);
                        break;
                    //case 2:
                    //    encriptado = EncriptarSHA256(inputMsj3.Text);
                        
                }
                

                txtResponse.Text = encriptado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            try
            {
                cleanRes();
                seleccionCaso();
                string desencriptado = "";


                switch (caso)
                {
                    case 0:
                        string texto = inputMsj1.Text;
                        string clave = inputClave1.Text;
                        desencriptado = DesencriptarAscii(texto, getClave(clave).Sum());
                        break;
                    case 1:
                        desencriptado = DesencriptarAes(inputMsj2.Text, inputClave2.Text);
                        break;
                    //case 'C':
                    //    desencriptado = DesencriptarMD5(texto);
                    //    break;
                }

                txtResponse.Text = desencriptado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string EncriptarAes(String texto)
        {
            string encriptado;
            if (pageSimetrico.Visible == true && texto != "" )
            {
                int longitud = 32;
                int longitudIV = 16;
                byte[] encriptar = Encoding.UTF8.GetBytes(texto);
                byte[] keyArray = GeneradorClave(longitud);
                byte[] iv = GeneradorClave(longitudIV);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyArray;
                    aes.IV = iv;
                    
                    using(MemoryStream memoryStream = new MemoryStream())
                    {
                        using(CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(encriptar,0,encriptar.Length);
                            cryptoStream.FlushFinalBlock();

                            return Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }
                }
                
            }
            else
            {
                encriptado = "No se puede encriptar un mensaje vacio";
            }

            return encriptado;
        }

        private string DesencriptarAes(String texto,String clave)
        {
            string desencriptado = "";


            return desencriptado;
        }
        
        private string EncriptarAscii(String texto, int clave)
        {
            char reemplazo;
            string encriptado = "";

            if (pageAscii.Visible == true && texto != "" && clave != 0)
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    reemplazo = (char)((int)texto[i] + clave);
                    encriptado += reemplazo.ToString();
                }
            }
            else
            {
                encriptado = "No se puede encriptar un mensaje vacio";
            }

            inputMsj1.Text = "";
            return encriptado;
        }
        
        private string DesencriptarAscii(string texto,int clave)
        {
            char reemplazo;
            string desencriptado = "";

            if (pageAscii.Visible == true && texto != "" && clave != 0)
            {
                for (int i = 0; i < texto.Length;i++)
                {
                    reemplazo = (char)((int)texto[i] - clave);
                    desencriptado += reemplazo.ToString();
                }

            } else
            {
                desencriptado = "No se puede desencriptar un mensaje vacio";
            }

            return desencriptado;

        }

        private void seleccionCaso()
        {
            if (pageAscii.Visible)
                caso = tbCtrl.TabPages.IndexOf(pageAscii);
            else if (pageAsimetrico.Visible)
                caso = caso = tbCtrl.TabPages.IndexOf(pageAsimetrico);
            else if (pageSimetrico.Visible)
                caso = tbCtrl.TabPages.IndexOf(pageSimetrico);
            else caso = tbCtrl.TabPages.IndexOf(pageHash);
        }

        private void cleanRes()
        {
            txtResponse.Text = "";
        }

        private IEnumerable<Int32> getClave(String clave)
        {
            int[] claveCode = new int [clave.Length];
            for(int i = 0;i < clave.Length; i++)
            {
                claveCode[i] += (int)clave[i];
                //claveCode[i] += Convert.ToInt32(Char.GetNumericValue(clave[i]));
            }

            return claveCode;
        }

        private byte[] GeneradorClave(int longitud)
        {
            byte[] keyArray = new byte[longitud];
            Random r = new Random();
            r.NextBytes(keyArray);

            return keyArray;
        }
    }
}