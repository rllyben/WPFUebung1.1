using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFÜbung1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Erstellung des MainGrids zusammen mit den Rows und Colomns
            Grid MainGrid = new Grid();
            RowDefinition MenueBarRow = new RowDefinition()
            {
                Height = new GridLength(20)
            };
            RowDefinition TextBlockRow = new RowDefinition()
            {
                Height = new GridLength(75)
            };
            RowDefinition ListRow = new RowDefinition();
            MainGrid.RowDefinitions.Add(MenueBarRow);
            MainGrid.RowDefinitions.Add(TextBlockRow);
            MainGrid.RowDefinitions.Add(ListRow);
            ColumnDefinition LeftSide = new ColumnDefinition();
            ColumnDefinition RightSide = new ColumnDefinition();
            MainGrid.ColumnDefinitions.Add(LeftSide);
            MainGrid.ColumnDefinitions.Add(RightSide);
            // MainGrid.SetValue(Grid.ShowGridLinesProperty, true);

            // Erstellung der Menue Bar mit allen untermenues und hinzufuegen zum MainGrid
            {
                Menu menu = new Menu();
                MenuItem file = new MenuItem();
                file.Header = "File";
                MenuItem neu = new MenuItem();
                neu.Header = "New";
                MenuItem open = new MenuItem();
                open.Header = "Open";
                MenuItem save = new MenuItem();
                save.Header = "Save";
                MenuItem exit = new MenuItem();
                exit.Header = "Exit";
                file.Items.Add(neu);
                file.Items.Add(open);
                file.Items.Add(save);
                file.Items.Add(new Separator());
                file.Items.Add(exit);
                menu.Items.Add(file);
                menu.SetValue(Grid.RowProperty, 0);
                menu.SetValue(Grid.ColumnProperty, 0);
                menu.SetValue(Grid.ColumnSpanProperty, 2);
                MainGrid.Children.Add(menu);
            }
            // Erstellund des obersten linken Textblocks mit Border und central alignment und hinzufuegen zum MainGrid
            {
                Border leftTextBlockBorder = new Border();
                leftTextBlockBorder.Margin = new Thickness(5, 5, 5, 5);
                leftTextBlockBorder.BorderBrush = new SolidColorBrush(Colors.Black);
                leftTextBlockBorder.BorderThickness = new Thickness(1);
                TextBlock leftTextBlock = new TextBlock();
                leftTextBlock.Text = "TextBlock";
                leftTextBlock.TextAlignment = TextAlignment.Center;
                leftTextBlock.SetValue(Border.VerticalAlignmentProperty, VerticalAlignment.Center);
                leftTextBlockBorder.Child = leftTextBlock;
                leftTextBlockBorder.SetValue(Grid.ColumnProperty, 0);
                leftTextBlockBorder.SetValue(Grid.RowProperty, 1);
                MainGrid.Children.Add(leftTextBlockBorder);
            }
            // Erstellung der ListBox und hinzufuegen zum MainGrid
            {
                ListBox leftListBox = new ListBox();
                //leftTextBlockBorder.Child = leftListBox;
                leftListBox.Items.Add("Hellow :3");
                leftListBox.BorderBrush = new SolidColorBrush(Colors.Black);
                leftListBox.BorderThickness = new Thickness(1);
                leftListBox.Margin = new Thickness(5, 5, 5, 5);
                MainGrid.Children.Add(leftListBox);
                Grid.SetRow(leftListBox, 2);
                Grid.SetColumn(leftListBox, 0);
            }
            // Erstellung des oberen rechten Grids für die beiden TextBloecke und hinzufuegen zum MainGrid
            {
                Grid RightTextBlockGrid = new Grid();
                for (int count = 0; count < 2; count++)
                {
                    RowDefinition TextBlockRows = new RowDefinition();
                    RightTextBlockGrid.RowDefinitions.Add(TextBlockRows);
                }
                RightTextBlockGrid.SetValue(Grid.ColumnProperty, 1);
                RightTextBlockGrid.SetValue(Grid.RowProperty, 1);
                // RightTextBlockGrid.SetValue(Grid.ShowGridLinesProperty, true);
                MainGrid.Children.Add(RightTextBlockGrid);

                // Erstellung der beiden TextBloecke im oberen rechten Grid und hinzufuegen zu diesem Grid
                {
                    for (int count = 0; count < 2; count++)
                    {
                        Border textBorder = new Border();
                        textBorder.Margin = new Thickness(5, 5, 5, 5);
                        textBorder.BorderBrush = new SolidColorBrush(Colors.Black);
                        textBorder.BorderThickness = new Thickness(1);
                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = "TextBlock";
                        textBlock.TextAlignment = TextAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBorder.Child = textBlock;
                        textBorder.SetValue(Grid.RowProperty, count);
                        RightTextBlockGrid.Children.Add(textBorder);
                    }

                }

            }
            // Erstellung des unteren rechten Grids und hinzufuegen zum MainGrid
            {
                Grid RightBigGrid = new Grid();
                for (int count = 0; count < 5; count++)
                {
                    RowDefinition RightRows = new RowDefinition();
                    RightBigGrid.RowDefinitions.Add(RightRows);
                }

                for (int count = 0; count < 2; count++)
                {
                    ColumnDefinition RightColumns = new ColumnDefinition();
                    if (count == 0)
                    {
                        RightColumns.Width = new GridLength(175);
                    }
                    RightBigGrid.ColumnDefinitions.Add(RightColumns);

                }
                RightBigGrid.SetValue(Grid.ColumnProperty, 1);
                RightBigGrid.SetValue(Grid.RowProperty, 2);
                // RightBigGrid.SetValue(Grid.ShowGridLinesProperty, true);
                MainGrid.Children.Add(RightBigGrid);

                // Erstellung der unteren linken TextBoecke und hinzufuegen in's untere rechte Grid
                {
                    for (int count = 0; count < 5; count++)
                    {
                        Border textBorder = new Border();
                        textBorder.Margin = new Thickness(5, 5, 5, 5);
                        textBorder.BorderBrush = new SolidColorBrush(Colors.Black);
                        textBorder.BorderThickness = new Thickness(1);
                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = "TextBlock";
                        textBlock.TextAlignment = TextAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBorder.Child = textBlock;
                        textBorder.SetValue(Grid.RowProperty, count);
                        textBorder.SetValue(Grid.VerticalAlignmentProperty, VerticalAlignment.Top);
                        RightBigGrid.Children.Add(textBorder);
                    }

                }
                // Erstellung der unteren rechten TextBoxen und hinzufuegen zum unteren rechten Grid
                {
                    for (int count = 0; count < 5; count++)
                    {
                        Border textBorder = new Border();
                        textBorder.Margin = new Thickness(5, 5, 5, 5);
                        textBorder.BorderBrush = new SolidColorBrush(Colors.Black);
                        textBorder.BorderThickness = new Thickness(1);
                        TextBox textBox = new TextBox();
                        textBox.Text = "TextBox";
                        textBox.TextAlignment = TextAlignment.Center;
                        textBox.VerticalAlignment = VerticalAlignment.Center;
                        textBox.BorderBrush = new SolidColorBrush(Colors.White);
                        textBorder.Child = textBox;
                        textBorder.SetValue(Grid.ColumnProperty, 1);
                        textBorder.SetValue(Grid.RowProperty, count);
                        RightBigGrid.Children.Add(textBorder);
                    }

                }

            }
            this.Content = MainGrid;
        }

    }

}