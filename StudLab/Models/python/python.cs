﻿using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StudLab.Models.python
{
    public static class python
    {
        public static int port = 6666;
        public static string socket(string message = null)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ipPoint);


            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);
            data = new byte[9999999];
            StringBuilder stringBuilder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = socket.Receive(data, data.Length, SocketFlags.None);
                stringBuilder.Append(Encoding.UTF8.GetString(data, 0, bytes));

            } while (socket.Available > 0);
            // закрываем сокет
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            return stringBuilder.ToString();
        }

        public static string run_cmd(string args= "--matrix \"6;6;8;5;4;3#2;4;3;22;8;5#3;5;7;22;6;11#3;5;4;4;2;1#2;5;6;3;2;8\" --avector \"130;55;80;65;135\" --bvector \"130;75;65;60;75;60\"")
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"D:\Programs\Python3.7.1\python.exe";
            start.Arguments = $"python\\northwest_corner.py {args}";
            start.UseShellExecute = false;// Do not use OS shell
            start.CreateNoWindow = true; // We don't need new window
            start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
            start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
            start.StandardOutputEncoding = Encoding.UTF8;
            try
            {
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                        string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")
                        return result;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return args;
            }
        }
        public static string northwest_corner(List<List<double>> matrix, List<double> a, List<double> b)
        {
            string str_matrix = String.Join('\n', matrix.Select(row => String.Join(';', row)));
            string A = String.Join(' ', a);
            string B = String.Join(' ', b);
            Console.WriteLine(str_matrix);
            Console.WriteLine(A);
            Console.WriteLine(B);
            run_cmd();
            return northwest_corner(str_matrix, A, B);
        }
        private static dynamic GetVariable(string path, string nameFunction)
        {
            try
            {
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();

                engine.ExecuteFile("python/northwest_corner.py", scope);
                dynamic Function = scope.GetVariable("northwest_corner");
                return Function;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }

        }
        public static string northwest_corner(string matrix, string a, string b)
        {
            dynamic Function = GetVariable(@"~/python/northwest_corner.py", "northwest_corner");
            dynamic result = Function(matrix, a, b);

            return result;
        }

        public static string PatchParameter(string parameter, int serviceid)
        {
            var engine = Python.CreateEngine(); // Extract Python language engine from their grasp
            ScriptSource source = engine.CreateScriptSourceFromFile("PATH_TO_PYTHON_SCRIPT_FILE"); // Load the script
            var scope = engine.CreateScope(); // Introduce Python namespace (scope)
            ObjectOperations op = engine.Operations;

            var d = new Dictionary<string, object>
            {
                { "serviceid", serviceid},
                { "parameter", parameter}
            }; // Add some sample parameters. Notice that there is no need in specifically setting the object type, interpreter will do that part for us in the script properly with high probability

            scope.SetVariable("params", d); // This will be the name of the dictionary in python script, initialized with previously created .NET Dictionary
            object result = source.Execute(scope);
            parameter = scope.GetVariable<string>("parameter"); // To get the finally set variable 'parameter' from the python script
            return parameter;
        }
    }
}
