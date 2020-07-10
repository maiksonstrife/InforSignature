﻿using System;
using System.IO;

namespace InforSignature
{
    public class ErrorLogging
    {
        //Essa classe salva um arquivo txt em meus documentos, na pasta infordocsolutions, com o erro do programa
        public static void ErrorLog(Exception ex)
        {
            string strPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\InfordocSolutions\Log\");

            string hourMinute;
            hourMinute = DateTime.Now.ToString("HH-mm");
            strPath += "Log" + hourMinute + ".txt";

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"\InfordocSolutions\Log\");

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }


            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }

            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine(" =============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }
        }

        public static void ReadError()
        {
            string logPath = @"\InfordocSolutions\Log\Log.txt";
            string strPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), logPath);
            using (StreamReader sr = new StreamReader(strPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
