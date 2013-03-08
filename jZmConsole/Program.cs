﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZombieAPI;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace jZmConsole
{
    class jZmException : Exception { public jZmException(string Msg) : base(Msg) { } }

    class Program
    {
        static ZombieAPI.ZombieAPI API;
        static void Main(string[] args)
        {
            string gameName;
            if (args.Length > 0)
                gameName = args[0];
            else gameName = "t6zm";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ZombieAPI.ZombieAPI.Header);
            Console.ForegroundColor = ConsoleColor.Gray;

            API = new ZombieAPI.ZombieAPI();
            API.OnWrite += new WriteHandler(API_OnWrite);
            API.OnPluginCrash += new OnPluginCrashHandler(API_OnPluginCrash);
            API.OnCrash += new OnCrashHandler(Crash);
            API.OnDebugWrite += new WriteHandler(API_OnDebugWrite);

            Process[] games = Process.GetProcessesByName(gameName);

            if (games.Length == 0)
                Crash(new jZmException("Game process '" + gameName + "' not found, try again"));
            if (games.Length > 1)
                Crash(new jZmException("More than 1 game process found. Use the GUI if you want to use multiple games."));

            API.Bootstrap(games[0]);

            Application.Run();
        }

        static void API_OnDebugWrite(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("[" + DateTime.Now.ToLongTimeString() + "] ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(msg);
        }

        static void API_OnPluginCrash(Exception exep, jZmPlugin plugin)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARNING: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Plugin '{0}' by '{1} has caused an {2}. Details:\r\n{3}", plugin.Name, plugin.Author, exep.GetType().FullName, exep.ToString());
        }

        static void API_OnWrite(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("["+DateTime.Now.ToLongTimeString()+"] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(msg);
        }

        static void Crash(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("FATAL ERROR: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ex.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\r\nPress enter to terminate jZm");
            Console.ReadLine();
            Environment.Exit(-1);
        }
        static bool anim = false;
        static int animc = -1;
        static void Anim()
        {
            anim = true;
            while (anim)
            {
                Thread.Sleep(100);
                Console.Write("\b");
                switch (animc)
                {
                    case 4:
                    case 0:
                        Console.Write("\\");
                        break;
                    case 3:
                    case 1:
                        Console.Write("|");
                        break;
                    case 2:
                        Console.Write("/");
                        break;
                }
            }
            
        }
    }
}
