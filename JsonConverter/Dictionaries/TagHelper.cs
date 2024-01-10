﻿using JsonPayloadConverter.TLV;
using System.Collections.Generic;
using static JsonPayloadConverter.Helper.ServicerConstants;

namespace JsonPayloadConverter.Dictionaries
{
    public static class TagHelper
    {
        public static Dictionary<byte[], (string tcParameter, string dalObject, string property)> TagMapper = new Dictionary<byte[], (string tcParameter, string dalObject, string property)>(ByteArrayComparer.Default)
        {
            //TODO: these are for testing only
            [E0Template.CardholderName] = (TCLinkParameter.EMVCardholderName, "Utils.Methods.LinkCardResponse", "CardholderName"),
            [E4Template.LanguagePreference] = (TCLinkParameter.EMVLanguagePreference, "CapturedEMVCardData", "LanguagePreference"),
            [E4Template.ThirdPartyData] = (TCLinkParameter.EMVThirdPartyData, "CapturedEMVCardData", "ThirdPartyData"),
            [E5Template.POSEntryMode] = (TCLinkParameter.EMVPosEntryMode, "CapturedEMVCardData", "POSEntryMode")
        };
    }
}
