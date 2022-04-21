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

	public partial class ChangeNote : Window
	{
		public ChangeNote()
		{
			InitializeComponent();
		}
		TeamsEntities db = TeamsEntities.GetContext();
		FP pl = new FP();
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			pl = db.FP.Find(Data.Номер);
			ID.Text = Convert.ToString(pl.Номер);
			FirstName.Text = pl.Имя;
			SecondName.Text = pl.Фамилия;
			MiddleName.Text = pl.Отчество;
			Team.Text = pl.Команда;
			PlayTeam.Text = Convert.ToString(pl.СыгранныхСезонов);
			Washers.Text = Convert.ToString(pl.ЧислоЗаброшенныхШайб);
			Assists.Text = Convert.ToString(pl.КолГолевыхПередач);
			PenaltyTime.Text = Convert.ToString(pl.ШтрафВремя);
			Matches.Text = Convert.ToString(pl.КолСыгранныхМатчей);

		}

		private void Change_Click(object sender, RoutedEventArgs e)
		{
			StringBuilder errors = new StringBuilder();
			if (ID.Text.Length == 0 && FirstName.Text.Length == 0 && SecondName.Text.Length == 0 && Team.Text != "Динамо" &&
				Team.Text != "Спартак" && PlayTeam.Text.Length == 0 && Matches.Text.Length == 0)
			{
				errors.AppendLine("Не все обязательные поля заполнены или заполнены некорректно");
			}
			if (errors.Length>0)
			{
				MessageBox.Show(errors.ToString());
				return;
			}
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
