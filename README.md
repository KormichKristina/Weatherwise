<img heigth=300px src="https://github.com/KormichKristina/Weatherwise/blob/master/imagesForReadme/Weatherwise%20icon.png"/>

## Weatherwise - небольшое приложение для просмотра прогноза погоды. В основные функции приложения входят просмотр прогноза, просмотр текущей погоды, просмотр уровня рагрязения воздуха.

### Скриншоты
<img src="https://github.com/KormichKristina/Weatherwise/blob/master/imagesForReadme/Weatherwise%20preview.png"/>
<img src="https://github.com/KormichKristina/Weatherwise/blob/master/imagesForReadme/Weatherwise%20preview2.png"/>
<img src="https://github.com/KormichKristina/Weatherwise/blob/master/imagesForReadme/Weatherwise%20preview3.png"/>

### Как скачать и использовать Weatherwise
для того чтобы скачать Weatherwise нужно воспользоваться коммандой `git clone` и затем указать URL:<br><br>
`git clone https://github.com/KormichKristina/Weatherwise.git`<br>
после того как вы скачали Weatherwise, запустите **Weatherwise.exe**<br><br>
**Weatherwise.exe** можно найти, следуя этому пути:<br> ..\Weatherwise\Weatherwise\bin\Debug\Weatherwise.exe
***
### Какие технологии были использованы
для красивого оформления приложения было использовано расширение **Guna.UI2.WinForms**. Это расширение позволяет быстро и легко улучшить внешний вид приложения.<br><br>
Также чтобы получать данные о погоде были использованны специальные API сайта OpenWeatherMap. Поскольку данные о погоде отсылались в виде Json, то пришлось использовать еще одно расширение - **Newtonsoft.Json**
***

### Небольшая документация
Хотелось бы отметить то, что чтобы корректно десериализовать Json, нужно было создать множество классов, которые **соотвествуют** присылаемому Json. Они находятся в папке **Classes**. В частности я бы хотела ознакомить вас с ними:<br>

```c#
public class Coordinates \\ Класс координат города
{
    public float Lon { get; set; } \\ Широта

    public float Lat { get; set; } \\ Долгота
    
}
```
В классе Coordinates, как можно заметить есть 2 aвтоматических свойства - Lat и Lon для задания координат города
***

```c#
public class MyWind 
{
    public float Speed { get; set; } \\ Скорость ветра
    
}
```
***
```c#
public class MainInfo 
{
    public float Temp { get; set; } \\ Температура
    public float Feels_like { get; set; } \\ Как ощущается
    public float Temp_min { get; set; } \\ Мин. температура
    public float Temp_max { get; set; } \\ Макс. температура
    public float Humidity { get; set; } \\ Влажность
    public float Pressure { get; set; } \\ Давление

}
```
***
```c#
public class MyWeather 
{
    public string Main { get; set; } \\ данные о погоде в виде строки
    public string Description { get; set; } \\ описание погоды
    public string Icon { get; set; } \\ id иконки погоды

}
```
***
```c#
public class SysInfo
{
    public long Sunrise { get; set; } \\ время рассвета в unix времени
    public long Sunset { get; set;} \\ время заката в unix времени

}
```
***
```c#
public class WeatherInfo 
{
    public string Name { get; set; } \\ Название города
    public Coordinates Coord { get; set; } \\ Координаты города
    public IList<MyWeather> Weather { get; set; } \\ список текущей погоды
    public long Timezone { get; set; } \\ Сдвиг времени города относительно времени Utc в секундах
    public SysInfo Sys { get; set; } \\ Информация о закате и рассвете города
    public MainInfo Main { get; set; } \\ общая информация о погоде
    public MyWind Wind { get; set; } \\ Ветер
    public TimeSpan GetHoursAndMin() \\ Метод который преобразует сдвиг времени в секундах в TimeSpan с часами и минутами
    {
        TimeSpan sp = new TimeSpan();

        int hours = (int)Timezone / 3600;
        int minutes = (int)Timezone - hours * 3600;
        minutes /= 60;
        sp = new TimeSpan(hours, minutes, 0);

        return sp;
    }


}
```
***
```c#
public class HourlyForecastInfo
{
    public MainInfo Main { get; set; } \\ общая информация о погоде
    public IList<MyWeather> Weather { get; set; } \\ список текущей погоды
    public MyWind Wind { get; set; } \\ Ветер
    public string Dt_txt { get; set; } \\ Текущее время

}
```
***
```c#
public class DailyWeatherForecastInfo
{
    public IList<HourlyForecastInfo> List { get; set; } \\ список погоды через каждые 3 часа напротяжение 3х дней

}
```
***
```c#
public class MyComponents
{

    public float Co { get; set; } \\ Уровень Со в воздухе
    public float No { get; set; } \\ Уровень Nо в воздухе
    public float No2 { get; set; } \\ Уровень Nо2 в воздухе
    public float O3 { get; set; } \\ Уровень O3 в воздухе
    public float So2 { get; set; } \\ Уровень Sо2 в воздухе
    public float Pm2_5 { get; set; } \\ Уровень Pm2.5 в воздухе
    public float Pm10 { get; set; } \\ Уровень Pm10 в воздухе
    public float Nh3 { get; set; } \\ Уровень Nh3 в воздухе

}
```
***
```c#
public class MainPollutionData
{
    public int Aqi { get; set; } \\ Air Quality Index

}
```
***
```c#
public class AirPollutionData
{
    public MainPollutionData Main { get; set; } \\ общий уровень загрязнения
    public MyComponents Components { get; set; } \\ Уровень разных компонентов в воздухе

}
```
***
```c#
 public class AirPollutionList
 {
     public IList<AirPollutionData> List { get; set; } \\ список загрязнений воздуха
     public AirPollutionData this[int index] \\ индексатор для удобства обращения к элементам List
     {
         get => List[index];
         set =>  List[index] = value;
     }
 }
```
***
```c#
public enum Degrees
{
    K, \\ Кельвины
    F, \\ Фаренгейты
    C \\ Цельсии
}
```
***
```c#
public enum WindSpeed
{
    M_C, \\ Скорость ветра в м/с
    KM_H \\ Скорость ветра в км/ч
}
```
***
```c#
public enum Pressure
{
    HPA, \\ Давление в гектопаскалях
    MMHG \\ Давление в мм рт.ст.
}
```
***
```c#
 public static class ExtensionClass
 {
     public static Image GetWeatherImage(this string str) \\ Получение изображения погоды из id погоды
     {

         string temp = str;
         temp=temp.Trim('d', 'n');

         switch (temp)
         {
             case "01":
                 return Resources.sun;
             case "02":
                 return Resources.few_clouds;
             case "03":
                 return Resources.scattered_clouds;
             case "04":
                 return Resources.broken_clouds;
             case "09":
                 return Resources.shower_rain;
             case "10":
                 return Resources.rain;
             case "11":
                 return Resources.thunderstorm;
             case "13":
                 return Resources.snow;
             case "50":
                 return Resources.mist;
             default:
                 return null;
         }
     }
     public static string GetAqiStr(this int aqi) \\ Получение строки состояния воздуха из aqi
     {
         switch (aqi)
         {
             case 1:
                 return "Good";
             case 2:
                 return "Fair";
             case 3:
                 return "Moderate";
             case 4:
                 return "Poor";
             default:
                 return "Very Poor";

         }
     }
     public static string GetStrDeg(this Degrees deg) \\ получение из объекта Degrees объект string
     {
         switch (deg)
         {
             case Degrees.K:
                 return "°K";
             case Degrees.F:
                 return "°F";
             default:
                 return "°C";
         }
     }
     public static string GetStrWindSpeed(this WindSpeed speed)\\ получение из объекта WindSpeed объект string
     {
         switch (speed)
         {
             case WindSpeed.KM_H:
                 return "km/h";
             default:
                 return "m/c";
         }
     }
     public static string GetStrPressure(this Pressure pressure) \\ получение из объекта Pressure объект string
     {
         switch (pressure)
         {
             case Pressure.MMHG:
                 return "mmHg";
             default:
                 return "hPa";
         }
     }
     public static Degrees GetDegrees(this string str)\\ получение из объекта string объект Degrees
     {
         switch (str)
         {
             case "°C":
                 return Degrees.C;
             case "°F":
                 return Degrees.F;
             default:
                 return Degrees.K;
         }
     }
     public static WindSpeed GetWindSpeed(this string str)\\ получение из объекта string объект WindSpeed
     {
         switch (str)
         {

             case "km/h":
                 return WindSpeed.KM_H;
             default:
                 return WindSpeed.M_C;
             
         }
     }
     public static Pressure GetMyPressure(this string str)\\ получение из объекта string объект Pressure
     {
         switch (str)
         {
             case "mmHg":
                 return Pressure.MMHG;
             default:
                 return Pressure.HPA;
         }
     }
 }
```
***
```c#
public static class SettingsClass
{
    public static Degrees TempDegrees {get;set;} \\Размерность градусов
    public static WindSpeed Wind { get; set; }\\Размерность скорости ветра
    public static Pressure MyPressure { get; set; }\\Размерность давления
    public static bool UseUtc { get; set; }\\логическая переменная которая указывает, используется ли местное время или время Utc
    public static string MyPathToSettingsData { get; } \\ Путь до файла настроек
    static SettingsClass() \\ статистический конструктор где вычисляется путь до файла настроек и задаются настройки
    {
        string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var path= Path.GetDirectoryName(location); 
        MyPathToSettingsData = path.Substring(0, path.Length - 9)+ "Data\\SettingsData.txt";

        if (File.Exists(MyPathToSettingsData))
        {
            string[] lines = File.ReadAllLines(MyPathToSettingsData);
            if (lines.Length < 4)
            {
                File.WriteAllLines(MyPathToSettingsData, new string[] { "°K", "m/c", "hPa", "false" });

                TempDegrees = Degrees.K;
                Wind = WindSpeed.M_C;
                MyPressure = Pressure.HPA;
                UseUtc = false;
            }
            else
            {
                TempDegrees = lines[0].GetDegrees();
                Wind = lines[1].GetWindSpeed();
                MyPressure = lines[2].GetMyPressure();
                UseUtc = Convert.ToBoolean(lines[3]);
            }
        }
        
    }
    public static void ChangeSettings() \\ Обновление настроек
    {
        File.WriteAllLines(MyPathToSettingsData, new string[] { TempDegrees.GetStrDeg(), Wind.GetStrWindSpeed(), MyPressure.GetStrPressure(), UseUtc.ToString() });
    }
}
```
***
```c#
public static class CitiesClass
{
    public static string PathToCitiesData { get; } \\Путь до файла с добавленными городами
    public static string CurrentCityName { get; set; } \\ Текущий город
    public static List<string> CitiesNames { get => citiesNames; } \\ Свойство для чтения которое возвращает список выбранных городов
    static List<string> citiesNames; \\ список выбранных городов
    static CitiesClass() \\Статистический конструктор в котором вычисляется путь до файла с добавленными городами
    {
        string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var path = Path.GetDirectoryName(location);
        PathToCitiesData = path.Substring(0, path.Length - 9) + "Data\\AddedCities.txt";
        CurrentCityName = File.ReadAllLines(PathToCitiesData)[0];

    }
    public static void GetCitiesNamesFromFile() \\ Добавление городов из файла в citiesNames
    {
        string[] lines = File.ReadAllLines(PathToCitiesData);
        citiesNames = lines.ToList();
    }
    public static void AddCityToFile(string city) \\ Добавление нового города в файл добавленных городов
    {
        var lines = File.ReadAllLines(PathToCitiesData).ToList();
        lines.Add(city);
        
        File.WriteAllLines(PathToCitiesData, lines);
        citiesNames.Add(city);
    }
    public static List<string> GetFullListOfCities() \\ Возвращение полного списка доступных городов
    {
        string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var path = Path.GetDirectoryName(location);
        string pathToFullCitiesList = path.Substring(0, path.Length - 9) + "Data\\Cities.txt";

        string[] list = File.ReadAllLines(pathToFullCitiesList);
        return list.ToList();
    }
    public static void RemoveCity(string city) \\ Удалить город из файла добавленных городов
    {
        var lines = File.ReadAllLines(PathToCitiesData).ToList();
        lines.Remove(city);
        File.WriteAllLines(PathToCitiesData, lines);

        if (city==CurrentCityName)
        {
            CurrentCityName = lines[0];
        }
        CitiesNames.Remove(city);

        
    }

}
```