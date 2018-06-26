using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeLifeWPF.Menus
{
    public class AltoContraste
    {
        public static bool Contraste { get; set; }
        public static void CambiarContraste()
        {
            if (!Contraste)
            {
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri("Themes/HighContrast.xaml", UriKind.Relative);

                Application.Current.Resources.MergedDictionaries.Add(dict);
                Contraste = true;
            }
            else
            {
                try
                {
                    Application.Current.Resources.MergedDictionaries[0].Clear();

                    ResourceDictionary dict = new ResourceDictionary();
                    dict.Source = new Uri("Themes/Default.xaml", UriKind.Relative);
                    Application.Current.Resources.MergedDictionaries.Add(dict);
                    Contraste = false;
                }
                catch (ArgumentOutOfRangeException er)
                {


                }
            }
            ;
        }
    }
}
