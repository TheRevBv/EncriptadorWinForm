using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
                    case 3:
                        encriptado = EncriptarSHA256(inputMsj3.Text);
                        break;
                        
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
                        desencriptado = DesencriptarAes(inputMsj2.Text);
                        break;
                    case 3:
                        desencriptado = DesencriptarSHA256(inputMsj4.Text);
                        break;
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
                    aes.KeySize = keyArray.Length * 4;
                    aes.BlockSize = iv.Length * 8;
                    aes.Key = keyArray;
                    aes.IV = iv;
                    //aes.Padding = PaddingMode.None;

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using(CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(encriptar,0,encriptar.Length);
                            cryptoStream.FlushFinalBlock();

                            encriptado = Convert.ToBase64String(memoryStream.ToArray());
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

        private string DesencriptarAes(String texto)
        {
            string desencriptado = "";

            if (pageSimetrico.Visible == true && texto != "")
            {
                int longitud = 32;
                int longitudIV = 16;
                byte[] desencriptar = Encoding.UTF8.GetBytes(texto);
                byte[] keyArray = GeneradorClave(longitud);
                byte[] iv = GeneradorClave(longitudIV);

                using (Aes aesProvider = Aes.Create())
                {
                    aesProvider.KeySize = keyArray.Length * 4;
                    aesProvider.Key = keyArray;
                    aesProvider.BlockSize = iv.Length * 8;
                    aesProvider.IV = iv;
                    ICryptoTransform decryptor = aesProvider.CreateDecryptor(aesProvider.Key, aesProvider.IV);

                    using (var ms = new MemoryStream(desencriptar))
                    {
                        using (var cryptoStream = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                        {

                            var dycrypted = new byte[desencriptar.Length];
                            cryptoStream.Write(desencriptar, 0, desencriptar.Length);
                            //cryptoStream.Close();
                            cryptoStream.FlushFinalBlock();

                        }
                            desencriptado = Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
            else
            {
                desencriptado = "No se pudo encriptar un mensaje vacio";
            }
            
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

        private string EncriptarSHA256(string texto)
        {
            string encriptado = "";

            if (pageHash.Visible == true && texto != "")
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));
                    StringBuilder builder = new StringBuilder();

                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    encriptado = builder.ToString();
                }
            }
            else
            {
                encriptado = "No se puede encriptar un mensaje vacio";
            }

            return encriptado;
            
        }
        
        private string DesencriptarSHA256(string texto){
            string desencriptado;

            if (pageHash.Visible == true && texto != "")
            {
                desencriptado = "No se puede desencriptar un mensaje encriptado con SHA256";
            }
            else
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
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                byte[] keyArray = new byte[longitud];
                provider.GetBytes(keyArray);

                return keyArray;
            }
        }
    }
}