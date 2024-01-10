using System.Collections.Generic;

namespace JsonPayloadConverter.Converter
{
    internal class MiFareConfigRequest
    {
        public int TransportApplicationKeyIndex { get; set; }
        public List<MiFareDataFileType> ApplicationFileIDs { get; set; } = new List<MiFareDataFileType>();
    }
}
