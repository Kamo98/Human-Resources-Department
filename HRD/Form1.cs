using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string login = "posgres";
			string pass = "Ntcnbhjdfybt_01";
			//string connectionString = "Server=hrd.cx7kyl76gv42.us-east-2.rds.amazonaws.com;Port=5432;User=" + login + ";Password=" + pass + ";Database=postgres;";

			string connectionString = "Server = hrd.cx7kyl76gv42.us-east-2.rds.amazonaws.com; DataBase = postgres; Integrated Security = false; User Id = " + login + "; password = " + pass;

			//Создание соединения с БД

			NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

			//Обработка исключения при создания исключения, тут выведется сообщение о неверном логине или пароле
			try
			{
				npgSqlConnection.Open();

				npgSqlConnection.Close();
			}
			catch (NpgsqlException)
			{
				npgSqlConnection = null;
				MessageBox.Show("Подключение НЕ выполнено");
			}

		}
	}
}
