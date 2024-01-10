using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace JsonPayloadConverter.Converter
{
    public class JsonRequestConverter
    {
        private static Lazy<JsonRequestConverter> LazyJsonConverter
            => new Lazy<JsonRequestConverter>(() => new JsonRequestConverter());

        protected JsonRequestConverter()
        {

        }

        public static JsonRequestConverter Instance
        {
            get
            {
                return LazyJsonConverter.Value;
            }
        }

        public string ConvertMiFareData()
        {
            LinkRequest linkRequest = new LinkRequest()
            {
                MiFareConfig = new MiFareConfigRequest()
                {
                    TransportApplicationKeyIndex = 3,
                    ApplicationFileIDs = new List<MiFareDataFileType>()
                    {
                        MiFareDataFileType.EnvironmentHolderFile,
                        MiFareDataFileType.StandardDataFile
                    }
                }
            };

            //string jsonString = JsonConvert.SerializeObject(linkRequest);
            string jsonString = JsonConvert.SerializeObject(linkRequest, Formatting.Indented, new JsonSerializerSettings
            {
                //NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                        new Newtonsoft.Json.Converters.StringEnumConverter()
                    }
            });
            //jsonString = jsonString.Replace('\n', ' ').Replace('\r', ' ');

            Debug.WriteLine(jsonString);
            Console.WriteLine(jsonString);

            return jsonString;
        }
    }
}
