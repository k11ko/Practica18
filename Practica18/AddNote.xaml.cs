using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica18
{
	/// <summary>
	/// Логика взаимодействия для AddNote.xaml
	/// </summary>
	public partial class AddNote : Window
	{
		public AddNote()
		{
			InitializeComponent();
		}
		TeamsEntities db = TeamsEntities.GetContext();

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			StringBuilder errors = new StringBuilder();
			//if (ID.Text.Length == 0) errors.AppendLine("Введите номер");
			//if (FirstName.Text.Length == 0) errors.AppendLine("Введите имя игрока");
			//if (SecondName.Text.Length == 0) errors.AppendLine("Введите фамилию игрока");
			//if (Team.Text != "Динамо" && Team.Text != "Спартак") errors.AppendLine("Выберите команду игрока");
			//if (PlayTeam.Text.Length == 0) errors.AppendLine("Введите количество сыгранных сезонов игрока");
			//if (Matches.Text.Length == 0) errors.AppendLine("Введите количество сыгранных матчей");
			//if(errors.Length>0)
			//{
			//	MessageBox.Show(errors.ToString());
			//	return;
			//}
			if(ID.Text.Length == 0 && FirstName.Text.Length == 0 && SecondName.Text.Length == 0 && Team.Text != "Динамо" && Team.Text != "Спартак" && PlayTeam.Text.Length == 0 && Matches.Text.Length == 0)
			{
				errors.AppendLine("Не все обязательные поля заполнены или заполнены некорректно");
			}
			if (errors.Length > 0)
			{
				MessageBox.Show(errors.ToString());
				return;
			}
			FP pl = new FP();
			try
			{
				pl.Номер = Convert.ToInt32(ID.Text);
				pl.Фамилия = SecondName.Text;
				pl.Имя = FirstName.Text;
				pl.Отчество = MiddleName.Text;
				pl.Команда = Team.Text;
				pl.СыгранныхСезонов = Convert.ToInt32(PlayTeam.Text);
				pl.ЧислоЗаброшенныхШайб = Convert.ToInt32(Washers.Text);
				pl.КолГолевыхПередач = Convert.ToInt32(Assists.Text);
				pl.ШтрафВремя = Convert.ToInt32(PenaltyTime.Text);
				pl.КолСыгранныхМатчей = Convert.ToInt32(Matches.Text);
				try
				{
					db.FP.Add(pl);
					db.SaveChanges();
					MessageBox.Show("Информация сохранена", "Успех");
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
			catch
			{
				MessageBox.Show("Не все обязательные поля заполнены или заполнены некорректно");
			}
		}

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
