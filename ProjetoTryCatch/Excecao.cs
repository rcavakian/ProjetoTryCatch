using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


namespace ProjetoTryCatch
{
    public static class Excecao
    {
        // Receber uma string e verificar se é uma data válida
        /// <summary>
        /// Verifica uma string se pode ser convertida no formato DateTime
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool VerificarData(string data)
        {
            try
            {
                DateTime date = Convert.ToDateTime(data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Receber uma string e verificar se é um inteiro válido
        /// <summary>
        /// Verifica uma string se pode ser convertida em um valor inteiro
        /// </summary>
        /// <param name="inteiro"></param>
        /// <returns></returns>
        public static bool VerificarInteiro(string inteiro)
        {
            try
            {
                int numero = Convert.ToInt32(inteiro);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Receber uma string e verificar se é um email válido

       public static bool VerificarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None);

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, 
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$", 
                    RegexOptions.IgnoreCase, 
                    TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {

                return false;
            }
        }
       

    }
}
