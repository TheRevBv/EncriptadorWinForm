using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Encriptador
{
    internal class RSA
    {
        private static string strFolderXML = @"C:\Users\Public\Documents\RSA\";
        /// <summary>
        /// Guarda un archivo XML de claves RSA 
        /// </summary>
        /// <param name="strNombreA">Nombre del archivo</param>
        public static void crearXMLclaves(string strNombreA)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            string xmlKey = rsa.ToXmlString(true);
            string strPath = strFolderXML + strNombreA;

            // Si no existe el directorio, crearlo
            string dirPruebas = Path.GetDirectoryName(strPath);

            if (Directory.Exists(dirPruebas) == false)
            {
                Directory.CreateDirectory(dirPruebas);
            }

            using (StreamWriter sw = new StreamWriter(strPath, false, Encoding.UTF8))
            {
                sw.WriteLine(xmlKey);
                sw.Close();
            }

        }
        /// <summary>
        /// Obtiene cadena de llaves RSA guardadas en un archivo XML
        /// </summary>
        /// <param name="strPath">Ruta del archivo</param>
        /// <returns>cadena de llaves RSA</returns>
        private static string clavesXML(string strPath)
        {
            string s;

            crearXMLclaves(strPath);

            using (StreamReader sr = new StreamReader(strPath, Encoding.UTF8))
            {
                s = sr.ReadToEnd();
                sr.Close();
            }

            return s;
        }

        /// <summary>
        /// Cifra una cadena en UTF8 y la pasa a un arreglo de Bytes
        /// </summary>
        /// <param name="strCad">Cadena a cifrar</param>
        /// <param name="xmlKeys">Llaves RSA con la que sera cifrada la cadena</param>
        /// <returns>Arreglo de bytes con cadena encriptada</returns>
        private static byte[] cifrar(string strCad, string xmlKeys)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xmlKeys);
            byte[] datosEnc = rsa.Encrypt(Encoding.UTF8.GetBytes(strCad), false);
            return datosEnc;
        }

        /// <summary>
        /// Descifra un arreglo de bytes y lo pone en una cadena codificada con UTF8
        /// </summary>
        /// <param name="datosEnc">Arreglo de bytes con cadena encriptada</param>
        /// <param name="xmlKeys">llaves para desencriptar</param>
        /// <returns>Cadena descifrada</returns>
        private static string descifrar(byte[] datosEnc, string xmlKeys)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xmlKeys);

            byte[] datos = rsa.Decrypt(datosEnc, false);

            string res = Encoding.UTF8.GetString(datos);

            return res;
        }

        /// <summary>
        /// Cifra una cadena y regresa cadena cifrada en base a 64
        /// </summary>
        /// <param name="strCadena">Cadena a Cifrar</param>
        /// <param name="strPath">Ruta del archivo de llaves RSA</param>
        /// <returns></returns>
        public static string CifraCadena(string strCadena, string strPath)
        {
            return Convert.ToBase64String(cifrar(strCadena, clavesXML(strPath)));
        }

        /// <summary>
        /// Descifra una cadena en base 64
        /// </summary>
        /// <param name="strCadena">Cadena cifrada</param>
        /// <param name="strPath">Ruta del archivo de llaves RSA</param>
        /// <returns></returns>
        public static string DescifrarCadena(string strCadena, string strPath)
        {
            return descifrar(Convert.FromBase64String(strCadena), clavesXML(strPath));
        }
    }
}
