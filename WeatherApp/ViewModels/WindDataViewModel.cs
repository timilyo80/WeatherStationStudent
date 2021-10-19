using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;

namespace WeatherApp.ViewModels
{
    public class WindDataViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet

        public DelegateCommand<string> GetDataCommand;
        //WindDataModel CurrentData;

        public double KPHtoMPS(double kph)
        {
            Double x = (Double)Decimal.Divide(1000, 3600);
            kph = kph * x;
            return Math.Round(kph,2);
        }

        public double MPStoKPH(double mps)
        {
            return mps * 3.6;
        }

        public bool CanGetData()
        {
            return GetDataCommand != null;
        }
    }
}
