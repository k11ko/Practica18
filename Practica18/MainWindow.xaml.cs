using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica18
{
	public static class Data
	{
		public static int Номер;
	}

	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		TeamsEntities db = TeamsEntities.GetContext();
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			db.FP.Load();
			tabl.ItemsSource = db.FP.Local.ToBindingList();
		}

		private void AddNote_Click(object sender, RoutedEventArgs e)
		{
			AddNote add = new AddNote();
			add.ShowDialog();
			tabl.Focus();
		}

		private void ChangeNote_Click(object sender, RoutedEventArgs e)
		{
			int IndexRow = tabl.SelectedIndex;
			if(IndexRow!= -1)
			{
				FP row = (FP)tabl.Items[IndexRow];
				Data.Номер = row.Номер;
				ChangeNote change = new ChangeNote();
				change.ShowDialog();
				tabl.Items.Refresh();
				tabl.Focus();
			}
		}

		private void DelNote_Click(object sender, RoutedEventArgs e)
		{
			int IndexRow = tabl.SelectedIndex;
			MessageBoxResult result;
			result = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if(result==MessageBoxResult.Yes)
			{
				try
				{
					FP row = (FP)tabl.Items[IndexRow];
					db.FP.Remove(row);
					db.SaveChanges();
				}
				catch(ArgumentOutOfRangeException)
				{
					MessageBox.Show("Сначала выберите запись", "Ошибка");
				}
			}
		}

		private void FindNote_Click(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i < tabl.Items.Count; i++)
			{
				var row = (FP)tabl.Items[i];
				string findContent = row.Фамилия;
				try
				{
					if(findContent != null && findContent.Contains(findSecondName.Text))
					{
						object item = tabl.Items[i];
						tabl.SelectedItem = item;
						tabl.ScrollIntoView(item);
						tabl.Focus();
						break;
					}
				}
				catch
				{
					MessageBox.Show("Человек не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		List<FP> _pl;
		private void filteredNote_Click(object sender, RoutedEventArgs e)
		{
			_pl = db.FP.ToList();
			var filtered = _pl.Where(_pl => _pl.Команда.Contains(findTeam.Text));
			tabl.ItemsSource = filtered;
		}

		private void filteredNoteback_Click(object sender, RoutedEventArgs e)
		{
			findTeam.Clear();
			_pl = db.FP.ToList();
			var filtered = _pl.Where(_pl => _pl.Команда.Contains(findTeam.Text));
			tabl.ItemsSource = filtered;
		}

		private void Info_Click(object sender, RoutedEventArgs e)
		{
			Information info = new Information();
			info.ShowDialog();
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void findSecondNameClear_Click(object sender, RoutedEventArgs e)
		{
			findSecondName.Clear();
		}
	}
}