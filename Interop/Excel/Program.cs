﻿using System;

namespace Excel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DataStruct data = new DataStruct ();
			IOWrite write = new IOWrite (data);

			//Набиране на данни в основната таблица

			data.addRow ("Мартин", "Стоев", "33");
			data.addRow ("Петър", "Георгиев", "54");

			//Проверка на таблицата

			data.printTable (); 

		}
	}
}
