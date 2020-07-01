using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using Microsoft.VisualBasic;
using System.IO.Compression;
using System.Security.Cryptography;


namespace systemsassss
{
	public class Upack
	{
		public static void Go_Start(string to_direct, string to_file)
		{
			Process.Start(new ProcessStartInfo()
			{
				WorkingDirectory = to_direct,
				FileName = to_file
			});
		}

		public static void Go(string pyt)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			Process.Start(pyt);
		}

		public static void Raspak(string maka, string gopa)
		{
			ZipFile.ExtractToDirectory(maka, gopa);
		}

		public static void Pack(string mk, string km)
		{
			ZipFile.CreateFromDirectory(mk, km);
		}
	}
	public class Program
	{
		static public string GetHash(string s)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(s);

			//создаем объект для получения средст шифрования  
			MD5CryptoServiceProvider CSP =
				new MD5CryptoServiceProvider();

			//вычисляем хеш-представление в байтах  
			byte[] byteHash = CSP.ComputeHash(bytes);

			string hash = string.Empty;

			//формируем одну цельную строку из массива  
			foreach (byte b in byteHash)
				hash += string.Format("{0:x2}", b);

			return hash;

		}
		private static string cmd;
		private static string ds;
        static void Main(string[] args)
		{
            string filese = File.ReadLines("CONFIG.sys").Skip(0).First();
                  string dire = File.ReadLines("CONFIG.sys").Skip(1).First();
               string exe = File.ReadLines("CONFIG.sys").Skip(2).First();
            Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("");
			Console.WriteLine("                           ██████╗  █████╗ ███╗   ███ ██╗           ██████  ╗██████╗ ███████╗"); 
			Console.WriteLine("                          ██╔═══██ ██╔══██ ████╗ ████ ██║           ██╔══██ ██╔═══██ ██╔════╝");
			Console.WriteLine("                          ██║   ██ ███████ ██╔████╔██ ██║    █████  ██║  ██ ██║   ██ ███████╗");
			Console.WriteLine("                          ██║   ██ ██╔══██ ██║╚██╔╝██ ██╚════       ██║  ██ ██║   ██ ╚════██║");
			Console.WriteLine("                          ╚██████╔ ██║  ██ ██║ ╚═╝ ██ ███████       ██████╔ ╚██████╔ ███████║");
			Console.WriteLine("                           ╚═════╝ ╚═╝  ╚═ ╚═╝     ╚═ ╚══════       ╚═════╝  ╚═════╝ ╚══════╝");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("");
			Console.WriteLine("                                        .----------------.  .----------------.");
			Console.WriteLine("                                       | .--------------. || .--------------. |");
			Console.WriteLine("                                       | |      _       | || |      _       | |");
			Console.WriteLine("                                       | |     | |      | || |     | |      | |");
			Console.WriteLine("                                       | |  ___| |___   | || |  ___| |___   | |");
			Console.WriteLine("                                       | | |___   ___|  | || | |___   ___|  | |");
			Console.WriteLine("                                       | |     | |      | || |     | |      | |");
			Console.WriteLine("                                       | |     |_|      | || |     |_|      | |");
			Console.WriteLine("                                       | |              | || |              | |");
			Console.WriteLine("                                       | '--------------' || '--------------' |");
			Console.WriteLine("                                        '----------------'  '----------------'");
			Console.ResetColor();
			Console.WriteLine("Привет. Это система OAML-DOS Beta");
			Console.WriteLine("----------------------------------------------------------------");
			Console.Write("Для помощи напишите: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("system.command.write.help");
			Console.ResetColor();
			Console.Write("Для завершения напишите: ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("system.command.app.off");
            Console.ResetColor();
            Console.Write("Для просмотра настроек программы напишите: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("system.command.config");
            Console.ResetColor();
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("Текущая версия приложения:");
			Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("╔=================╗");
			Console.Write("║    ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("0.6 ");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Beta   ");
			Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  ║");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("╚=================╝");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.ResetColor();
            Console.WriteLine("");
			bool ff = "aa" == "aa";
			while (ff)
			//========================================================
			{
				string ConvertToString(string[] text, int sleep = 1)
				{
					string done = "", result = "";
					for (int i = 0; i <= text.Length - 1; i++)
					{
						if (sleep <= i)
						{
							done += text[i] + " ";
						}
						else
						{

						}
					}
					done = done.TrimStart(' ');
					done = done.TrimEnd(' ');//delete problems.
					result = done;
					return result;
				}
				string ConvertToSatring(string[] text, int sleep = 0)
				{
					string done = " ", result = "";
					for (int i = 0; i <= text.Length - 1; i++)
					{
						if (sleep <= i)
						{
							done += text[i] + " ";

						}
						else
						{

						}
					}
					done = done.TrimStart(' ');

					done = done.TrimEnd(' ');//delete problems.

					result = done;
					return result;
				}
				//==========================================================
				Console.ForegroundColor = ConsoleColor.Yellow;
				string rootPath = Path.GetPathRoot(Environment.CurrentDirectory);
				Console.Write(rootPath + "> ");
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				//============================================
				string cmd = "";
				string ds = "";
				bool file1 = filese == "FILES=true";
				bool dir1 = dire == "DIRS=true";
				cmd = ds = Console.ReadLine();
				bool ddd = cmd == "echo";
				bool exe1 = exe == "EXEC=true";
				string[] argovn = cmd.Split(' ');
				string[] ardgs = cmd.Split(' ');

				//============================================

				string[] ardogs = ardgs[0].Split(' ');
				Console.ResetColor();

				if (cmd == "system.command.write.help")
				{
					Console.WriteLine("--------------------------------------------------------------------------------------");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Основные команды#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.OFF ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= выключить ПК");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.config ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= просмотр настроек OAML-DOS++");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды наименования 'app'#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.app.off ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= выключить программу");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды наименования 'write'#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.write.help ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= полный список всех команд");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.write.about ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= информация о программе");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.write.echo ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= набранное слово выводится консолью");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды наименования 'create'#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.create.directory ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= создает папку в указанном пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.create.txt ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= создает текстовой документ в указаном пути");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды наименования 'file'#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.write ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= позволяет редактировать текстовый документ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.read ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= показывает содержимое текстового документа в указанном пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.zip ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= команда для создания .zip архива");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.unzip ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= команда для распаковывания .zip архива");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.go ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= переносит в указанный вами путь, также может открывать обычные приложения");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.advancedgo ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= запускает приложение с параметрами директории (необходимо указать");
					Console.Write("полный путь до нужного вам приложения),");
					Console.WriteLine(" эта команда нужна для специальных приложений");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.delete ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= удаляет файл в указанном до него пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.redirectore.and.rename ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= позволяет перемещать или переименовывать файл/директорию.");
					Console.WriteLine("Имеет 2 аргумента");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды наименования 'directory'#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.directory.dir ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= смотрит содержимое папок в указанном пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.directory.delete ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= удаляет папки и их содержимое в указанном до них пути");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды наименования 'in'#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.in.base64 ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= набранное слово или текст выводится в кодировке Base64");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.in.md5 ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= набранное слово или текст выводится в хеше Md5");
					Console.ResetColor();
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
					Console.WriteLine("#Команды для помощи#");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.write ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= все команды наименования 'write'");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.app ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= все команды наименования 'app'");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.create ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= все команды типа 'create'");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= все команды типа 'file'");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.directory ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= все команды типа 'directory'");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.in ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= все команды типа 'in'");
					Console.ResetColor();
					Console.WriteLine("--------------------------------------------------------------------------------------");
				}

				else if (cmd == "system.command.config")
				{
					Console.WriteLine("Здесь вы можете просмотреть настройки этой программы (изменить их можно в файле CONFIG.sys),");
					Console.WriteLine("с последующими обновлениями спектр настроек будет расширяться...");
					Console.WriteLine("");
					Console.WriteLine("Описание настроек:");
					Console.WriteLine("");
					Console.WriteLine("Управление директориями - позволяет производить операции с директориями");
					Console.WriteLine("Управление файлами - позволяет делать операции с файлами");
					Console.WriteLine("Запуски - даёт возможность запускать приложения");
					Console.WriteLine("");
					string di;
					string hui;
					string onli;
					Console.Write("Файлы: ");
					if (filese == "FILES=true")
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("ВКЛ\n");
						Console.ResetColor();
					}
					else { Console.ForegroundColor = ConsoleColor.Red; Console.Write("ОТКЛ\n"); }
					Console.ResetColor();
					Console.Write("Директории: ");
				if (dire == "DIRS=true")
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("ВКЛ\n");
					Console.ResetColor();
				}
					else { Console.ForegroundColor = ConsoleColor.Red; Console.Write("ОТКЛ\n"); }
					Console.ResetColor();
					Console.Write("Исполняемые файлы: ");
					if (exe1)
					
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("ВКЛ\n");
						Console.ResetColor();
					}
					else { Console.ForegroundColor = ConsoleColor.Red;  Console.Write("ОТКЛ\n"); }
					Console.ResetColor();
					Console.Write("\n");
				}
				else if (cmd == "system.command.app.off")
                {

                    Environment.Exit(0);
                }
                else if (cmd == "system.OFF")
                {

                    Process p = new Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.Arguments = "/c shutdown -s -t 00";
                    p.Start();
                }
                else if(argovn[0] == "system.command.file.unzip" && file1)

                {
                    string mason1 = ConvertToSatring(argovn, 1);
                    string word = mason1.Substring(0, mason1.IndexOf(' '));
                    string mason2 = ConvertToSatring(argovn, 2);
                    Upack.Raspak(word, mason2);
                }
                else if(argovn[0] == "system.command.file.zip" && file1)
                {
                    try
                    {
                        string mason1 = ConvertToSatring(argovn, 1);
                        string word = mason1.Substring(0, mason1.IndexOf(' '));
                        string mason2 = ConvertToSatring(argovn, 2);
                        Upack.Pack(word, mason2);
                    }
                    catch (UnauthorizedAccessException) { Console.WriteLine("проверьте путь и запуск от имени админа!"); }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }   
                else if(argovn[0] == "system.command.file.go" && exe1)
                    {
                    try
                    {
                        string mason1 = ConvertToSatring(argovn, 1);
                       
                        Upack.Go(mason1);
                    }
                    catch (UnauthorizedAccessException) { Console.WriteLine("проверьте путь и запуск от имени админа!"); }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }
                else if(argovn[0] == "system.command.file.advancedgo" && exe1)
                {
                    string mason1 = ConvertToSatring(argovn, 1);
                    string word = mason1.Substring(0, mason1.IndexOf(' '));
                    string mason2 = ConvertToSatring(argovn, 2);
                    try
                    {

                        Upack.Go_Start(word,mason2);
                    }
                    catch (UnauthorizedAccessException) { Console.WriteLine("проверьте путь и запуск от имени админа!"); }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }
                else if (cmd == "system.command.write.about")
                {
                    Console.WriteLine(' ');
                    Console.WriteLine("            ================");
                    Console.WriteLine("            = Разработчики =");
                    Console.WriteLine("            ================");
                    Console.WriteLine("");
                    Console.WriteLine("&**************************************&");
                    Console.WriteLine("&                                      &");
                    Console.Write("&");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("        Создатель");
                    Console.ResetColor();
                    Console.Write(" - БМВ");
                    Console.WriteLine("               &");
                    Console.Write("&");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("        Дистрибутив ++ ");
                    Console.ResetColor();
                    Console.WriteLine("- Кремзон      &");
                    Console.WriteLine("&                                      &");
                    Console.WriteLine("&**************************************&");
                    Console.Write("& Текущая версия приложения = 0.6 ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Beta");
                    Console.ResetColor();
                    Console.WriteLine(" &");
                    Console.WriteLine("&**************************************&");
                    Console.WriteLine("");
                }
                else if (cmd == "system.command.app")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Доступные наименования команд типа 'app'");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.app.off1 ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= выключить программу");
					Console.ResetColor();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("");
                }
                else if (cmd == "system.command.write")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Доступные наименования команд типа 'write'");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.write.help ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= спсиок всех команд");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.write.about ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= информация о программе");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.write.echo ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= набранное слово выводится консолью");
                    Console.ResetColor();
					Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------------------");
                }
                else if (ardgs[0] == "system.command.create.directory" && dir1)
                {
                    Console.WriteLine("Введите путь для создания папки");
                    Console.Write("Пример ввода пути: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("C:\\(название папки)\\");
                    Console.ResetColor();
                    Console.WriteLine("(С двойными /)");
                    Directory.CreateDirectory(ConvertToString(ardgs, 1));
                    Console.WriteLine("папка создана");
                }
                else if (ardgs[0] == "system.command.create.txt" && file1)
                {
                    Console.WriteLine("Введите путь для создания текстового документа");
                    Console.Write("Пример ввода пути: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("C:\\(название текстового документа).txt");
                    Console.ResetColor();
                    Console.WriteLine("(С двойными /)");
                    try { File.Create(ConvertToString(ardgs, 1)); Console.WriteLine("файл сoздан!"); }
                    catch (UnauthorizedAccessException) { Console.WriteLine("для данного действия запустите от имени админа"); }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }
                else if (ardgs[0] == "system.command.file.read" && file1)
                {
                    Console.WriteLine("Введите путь до текстового документа, который требуется открыть");
                    Console.Write("Пример ввода пути: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("C:\\(название текстового документа).txt");
                    Console.ResetColor();
                    Console.WriteLine("(С двойными /)");
                    // чтение из файла
                    try
                    {
                        using (FileStream fstream = File.OpenRead(ConvertToString(ardgs, 1)))
                        {
                            // преобразуем строку в байты
                            byte[] array = new byte[fstream.Length];
                            // считываем данные
                            fstream.Read(array, 0, array.Length);
                            // декодируем байты в строку
                            string textFromFile = System.Text.Encoding.Default.GetString(array);
                            Console.WriteLine(textFromFile);

                        }
                    }
                    catch (UnauthorizedAccessException) { Console.WriteLine("проверьте путь и запуск от имени админа!"); }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }
                else if (ardgs[0] == "system.command.file.write" && file1)
                {
                    Console.WriteLine("Введите путь до текстового документа, который требуется редактировать");
                    Console.Write("Пример ввода пути: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("C:\\(название текстового документа).txt");
                    Console.ResetColor();
                    Console.WriteLine("(С двойными /)");
                    try
                    {
                        using (FileStream fstream = File.OpenRead(ConvertToString(ardgs, 1)))


                        {
                            // преобразуем строку в байты
                            byte[] array = new byte[fstream.Length];
                            // считываем данные
                            fstream.Read(array, 0, array.Length);
                            // декодируем байты в строку
                            string textFromFile = System.Text.Encoding.Default.GetString(array);
                            Console.WriteLine("сейчас текст равен: " + textFromFile);
                        }
                        Console.WriteLine("Введите строку(и) для записи в файл:");
                        string text = Console.ReadLine();

                        // запись в файл
                        using (FileStream fstream = new FileStream(ConvertToString(ardgs, 1), FileMode.OpenOrCreate))
                        {
                            // преобразуем строку в байты
                            byte[] array = System.Text.Encoding.Default.GetBytes(text);
                            // запись массива байтов в файл
                            fstream.Write(array, 0, array.Length);
                            Console.WriteLine("Текст записан в файл");
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("для данного действия запустите от имени админа,или,файл не найден");
                    }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }

                }
                else if (ardgs[0] == "system.command.directory.dir")
                {
                    try
                    {

                      
                        DirectoryInfo dir = new DirectoryInfo(ConvertToString(ardgs, 1));

                        // Для извлечения имени файла используется цикл foreach и свойство files.name
                        Console.WriteLine("        _______________________________");
						Console.WriteLine("       &");
                        foreach (FileInfo files in dir.GetFiles())
                        {
                            Console.WriteLine("       | ФАЙЛ=> # " + files.Name);

                        }
                        dir = new DirectoryInfo(ConvertToString(ardgs, 1));
                        foreach (var item in dir.GetDirectories())
                        {
                            Console.WriteLine("       | ПАПКА=> # " + item.Name);
                            
                            
                        }
                        Console.WriteLine("       &_______________________________");
                    }
                    catch { Console.WriteLine("пустой путь!или данного пути не существует"); }

                }
                else if(argovn[0] == "__top__secret__test__command__mas")
                    {
                   
                    string mason1 = ConvertToSatring(argovn, 1);
                    string word = mason1.Substring(0, mason1.IndexOf(' '));
                    string mason2 = ConvertToSatring(argovn, 2);
                    Console.WriteLine(word);
                    Console.WriteLine(mason2);
                }
                else if (ardgs[0] == "system.command.write.echo")

                { Console.WriteLine(ConvertToString(ardgs, 1)); }

                else if (ardgs[0] == "system.command.in.base64")
                {
                   
                    var dd = Encoding.UTF8.GetBytes(ConvertToString(ardgs, 1));
                    string enText = Convert.ToBase64String(dd);
                    Console.WriteLine(enText);
                }
				else if (ardgs[0] == "system.command.in.md5")
				{
					var dd = ConvertToString(ardgs, 1);

				 string hash = GetHash(dd);
					Console.WriteLine(hash);
				}
				else if (cmd == "")
                {
                    Console.WriteLine("пустая команда!");
                }
                else if (cmd == " ")
                {
                    Console.WriteLine("пустая команда!");
                }
                else if (cmd == "sandbox.time")
                { Console.WriteLine(DateTime.Now); }

                else if (ardgs[0] == "system.command.file.delete" && file1)
                {
                    try
                    {
                        File.Delete(ConvertToString(ardgs, 1));
                    }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }
                else if (ardgs[0] == "system.command.directory.delete" && dir1)
                {
                    try
                    {
                        Directory.Delete(ConvertToString(ardgs, 1), true);
                    }
                    catch (ArgumentException) { Console.WriteLine("пустой путь!"); }
                }
                else if (argovn[0] == "system.command.file.redirectore.and.rename" && file1 && dir1)
                {
                    try
                    {
                        string mason1 = ConvertToSatring(argovn, 1);
                        string word = mason1.Substring(0, mason1.IndexOf(' '));
                        string mason2 = ConvertToSatring(argovn, 2);
                      
                        string ggg = Console.ReadLine();
                        FileSystem.Rename(word, mason2);
                    }
                    catch (FileNotFoundException) { Console.WriteLine("файл не обнаружен!"); }
                    
                }
                else if (cmd == "system.command.create")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Доступные наименования команд типа 'create'");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.create.directory ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= создает папку в указанном пути");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.create.txt ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= создает текстовой документ в указаном пути");
					Console.ResetColor();
                    Console.WriteLine("----------------------------------------------------------------------");
                }
                else if (cmd == "system.command.file")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Доступные наименования команд типа 'file'");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.write ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= позволяет редактировать текстовый документ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.read ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= показывает содержимое текстового документа в указанном пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.zip ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= команда для создания .zip архива");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.unzip ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= команда для распаковывания .zip архива");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.go ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= переносит в указанный вами путь, также может открывать обычные приложения");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.advancedgo ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= запускает приложение с параметрами директории (необходимо указать");
					Console.Write("полный путь до нужного вам приложения),");
					Console.WriteLine(" эта команда нужна для специальных приложений");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.delete ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= удаляет файл в указанном до него пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.file.redirectore.and.rename ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= позволяет перемешать или переименовывать файл/директорию.");
					Console.WriteLine("Имеет 2 аргумента");
					Console.ResetColor();
					Console.WriteLine("--------------------------------------------------------------------------------------------------");
                }
                else if (cmd == "system.command.directory")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Доступные наименования команд типа 'directory'");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------------------------------------------");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.directory.dir ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= смотрит содержимое папок в указанном пути");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.directory.delete ");
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= удаляет папки и их содержимое в указанном до них пути");
					Console.ResetColor();
					Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (cmd == "system.command.in")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Доступные наименования команд типа 'in'");
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("system.command.in.base64 ");
                    Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= набранное слово выводится в кодировке Base64");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("system.command.in.md5 ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("= набранное слово или текст выводится в хеше Md5");
					Console.ResetColor();
					Console.WriteLine("-----------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Команды " + cmd + " не существует. Пожалуйста, перепроверьте синтаксис команды или её наличие!");
                    Console.WriteLine("");
                    Console.WriteLine("Пример правильного синтаксиса:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("system.command.(тип команды).(её наименование)");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("Для того чтобы узнать список всех команд, напишите:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("system.command.write.help");
                    Console.WriteLine("");
                    Console.ResetColor();
                }

			}

		}
        
	}

}
