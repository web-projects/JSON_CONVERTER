using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace JsonPayloadConverter.Converter
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MiFareDataFileType : int
    {
        EnvironmentHolderFile = 0,
        LinearFilewithBackup = 1,
        DataFileWithBackup2 = 2,
        DataFileWithBackup3 = 3,
        DataFileWithBackup4 = 4,
        DataFileWithBackup5 = 5,
        DataFileWithBackup6 = 6,
        StandardDataFile = 8,
        DataFileWithBackup9 = 9,
        DataFileWithBackup10 = 10,
        DataFileWithBackup11 = 11,
        ValueWithBackup12 = 12,
        ValueWithBackup13 = 13,
        ValueWithBackup14 = 14,
        ValueWithBackup15 = 15,
        DataFileWithBackup16 = 16,
        DataFileWithBackup17 = 17,
        DataFileWithBackup18 = 18,
        DataFileWithBackup19 = 19,
        DataFileWithBackup20 = 20,
        DataFileWithBackup21 = 21,
        DataFileWithBackup22 = 22,
        DataFileWithBackup23 = 23,
        DataFileWithBackup24 = 24,
        DataFileWithBackup25 = 25,
        DataFileWithBackup26 = 26,
        DataFileWithBackup27 = 27,
        DataFileWithBackup28 = 28,
        LinearFileWithBackup = 29,
        StandardDataFile30 = 30
    }
}
