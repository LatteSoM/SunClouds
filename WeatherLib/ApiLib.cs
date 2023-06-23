using ForecastModels;
using ApiModels;
using GeocodedModel;
using HourlyForecastModel;
using Newtonsoft.Json;

namespace WeatherLib
{

    public enum GraphMode  // режимы для графика
    {
        Temp = 0,  // режим для отображения информации о температуре
        FeelsLike = 1,  // режим для отображения информации о температуре по ощущениям
        Pressure = 2  // режим для отображения информации о давлении
    }

    /// <summary>
    /// Класс <c>ApiLib(<param>string ApiKey</param>)</c> - основной класс библиотеки, в нем прописаны методы взаимодействия с сервисом OpenWeather
    /// 
    /// Глобальные переменные и атрибуты: 
    /// 
    /// <c>ApiKey</c> - атрибут класса, строковый параметр. Ключ, генерирующийся на сайте сервиса OpenWeather и с помощью которого можно получить дступ к API
    /// <c>API_CONNECTION_URL</c> - глобальная переменная. Ссылка для получения информации при помощи API из сервиса OpenWeather
    /// 
    /// Здесь описаны следующие методы:
    /// 
    /// 1. <c>GetApiResponse(<param>string _request</param>)</c> - Фундаментальный метод, для осуществления get-запросов. На нем построены остальные методы
    /// взаимодействия с API. На вход получает строку запроса. 
    ///     Возвращаемое значение:
    ///         - <c>string response</c> - возвращает JSON-ответ от сервера
    ///
    /// 2. <c>GetGeocodedObject(<param>string _request</param>)</c> - Метод для получения информации о городе при помощи геокодера. На вход принимает название 
    /// города в строковом типе данных.
    ///     Возвращаемые значения:
    ///         - <c>GeocodedObject obj</c> - Объект десериализованный по модели GeocodedObject. (см. описание моделей)
    ///         
    /// 3. <c>GetCurrentWeather(<param>string _request</param>)</c> - Метод для получения информации о текущей погоде в определенном городе. На вход принимает название 
    /// города в строковом типе данных.
    ///     Возвращаемые значения:
    ///         - <c>CurrentWeather obj</c> - Объект десериализованный по модели CurrentWeather. (см. описание моделей)
    /// 
    /// 4. <c>GetForecastObject(<param>string _request</param>)</c> - Метод для получения прогноза погоды на ближайщие 40 дней в определенном городе. На вход принимает название 
    /// города в строковом типе данных.
    ///     Возвращаемые значения:
    ///         - <c>Forecast obj</c> - Объект десериализованный по модели Forecast. (см. описание моделей)
    ///         
    /// 5. <c>GetHourlyForecast(<param>string _request</param>)</c> - Метод для получения почасового прогноза погоды на ближайшие 48 часов в определенном городе На вход принимает название 
    /// города в строковом типе данных.
    ///     Возвращаемые значения:
    ///         - <c>HourlyForecastObject obj</c> - Объект десериализованный по модели HourlyForecastObject. (см. описание моделей)
    /// 
    /// 6. <c>GetGraphPoints(<param>string _city, GraphMode mode, int hours = 8</param>)</c> - Метод позволяющий получить точки для графика температуры, температуры по ощущениям и давления.
    /// На вход принимает: строкое название города _city, перечисляемый тип режима для выходного списка, количество точек по часам, значение должно быть не меньше 0 и не больше 47.
    ///     Возвращаемые значения:
    ///         - <c>List<double> points</c> - список с точками вещественного типа данных.
    ///         
    /// </summary>
    public class ApiLib
    {
        private static string API_CONNECTION_URL = "http://api.openweathermap.org/";

        public string ApiKey { get; private set; }

        public ApiLib(string _api_key) { ApiKey = _api_key; }



        public string GetApiResponse(string _request)
        {
            HttpClient http = new HttpClient();
            HttpResponseMessage response = http.GetAsync(_request).Result;  // запрос на получение данных с сервера
            if (!(response is null))
            {
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else  // выкидываю ошибку в случае, если статус, возвращаемого сервером кода неравен успешному.
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            else  // если сервер вернул пустой JSON выкидываю NullReference
            {
                throw new NullReferenceException("Server returned empty JSON");
            }
        }

        public GeocodedObject GetGeocodedObject(string _city)
        {

            var json_response = GetApiResponse(  // Получаю информацию по заданному запросу

                API_CONNECTION_URL + $"geo/1.0/direct?q={_city}&limit=1&appid={ApiKey}"

             );
            var geocoded_obj = JsonConvert.DeserializeObject<GeocodedObject>(json_response);  // Десериализую ответ по соответсвующей модели
            return geocoded_obj;

        }

        public CurrentWeather? GetCurrentWeather(string _city)
        {
            try
            {
                GeocodedObject geocoded_city = GetGeocodedObject(_city);
                var json_response = GetApiResponse(

                    API_CONNECTION_URL + $"data/2.5/weather?lat={geocoded_city.lat}&lon={geocoded_city.lon}&appid={ApiKey}"

                );
                var curr_weather = JsonConvert.DeserializeObject<CurrentWeather>(json_response);
                return curr_weather;

            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public Forecast? GetForecastObject(string _city)
        {
            try
            {

                GeocodedObject geocoded_city = GetGeocodedObject(_city);
                var json_response = GetApiResponse(

                    API_CONNECTION_URL + $"data/2.5/forecast?lat={geocoded_city.lat}&lon={geocoded_city.lon}&appid={ApiKey}"

                );
                var forecast = JsonConvert.DeserializeObject<Forecast>(json_response);
                return forecast;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public HourlyForecastObject? GetHourlyForecast(string _city)
        {
            try
            {
                GeocodedObject geocoded_city = GetGeocodedObject(_city);

                var json_response = GetApiResponse(

                    API_CONNECTION_URL + $"data/2.5/onecall?lat={geocoded_city.lat}&lon={geocoded_city.lon}&exclude=current,minutely,daily,alerts&appid={ApiKey}"
                );

                var h_forecast = JsonConvert.DeserializeObject<HourlyForecastObject>(json_response);
                return h_forecast;
            }
            catch (NullReferenceException)
            {
                return null;
            }

        }

        public List<double>? GetGraphPoints(string _city, GraphMode mode, int hours = 8)
        {
            try
            {
                List<double> points = new List<double>();
                var h_forecast_list = GetHourlyForecast(_city).hourly;

                if ((hours > 47) || (hours < 0))  // Проверка на введенный параметр
                {
                    throw new Exception("Value is too big or too small. the boundary values are 0 and 47");
                }

                for (int i = 0; i < hours; i++)
                {
                    if (mode == GraphMode.Temp)  // По соответствующему режиму добавляю информацию
                    {
                        points.Add(h_forecast_list[i].temp);  // добавляю значения температуры, если выбран режим температуры и так далее
                    }
                    else if (mode == GraphMode.FeelsLike)
                    {
                        points.Add(h_forecast_list[i].feels_like);
                    }
                    else if (mode == GraphMode.Pressure)
                    {
                        points.Add(h_forecast_list[i].pressure);
                    }
                }

                return points;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
    }
}