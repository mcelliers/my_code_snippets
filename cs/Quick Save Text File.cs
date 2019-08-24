 using System.IO;
 
 /*********************************************************************************************\
 *		Quantum Design and Engineering (PTY) Ltd		
 *			
 *
 \*********************************************************************************************/
 
 string FileName = $"C:\\Log\\ListnerDebug{DateTime.Now.DayOfYear}-{DateTime.Now.Hour}-{DateTime.Now.Second}.txt";
 string DataToSave = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
 
 File.WriteAllText(fn, DataToSave);