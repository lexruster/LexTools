using System;
using LexTools.Contract.Dictionaries;

namespace LexTools.Converter.EnumHelper
{
    public static class UsStateExtensions
    {
        public static string GetStateName(this LexTools.Contract.Dictionaries.UsState state)
        {
            switch (state)
            {
                case UsState.AL:
                    return "ALABAMA";

                case UsState.AK:
                    return "ALASKA";

                case UsState.AS:
                    return "AMERICAN SAMOA";

                case UsState.AZ:
                    return "ARIZONA";

                case UsState.AR:
                    return "ARKANSAS";

                case UsState.CA:
                    return "CALIFORNIA";

                case UsState.CO:
                    return "COLORADO";

                case UsState.CT:
                    return "CONNECTICUT";

                case UsState.DE:
                    return "DELAWARE";

                case UsState.DC:
                    return "DISTRICT OF COLUMBIA";

                case UsState.FM:
                    return "FEDERATED STATES OF MICRONESIA";

                case UsState.FL:
                    return "FLORIDA";

                case UsState.GA:
                    return "GEORGIA";

                case UsState.GU:
                    return "GUAM";

                case UsState.HI:
                    return "HAWAII";

                case UsState.ID:
                    return "IDAHO";

                case UsState.IL:
                    return "ILLINOIS";

                case UsState.IN:
                    return "INDIANA";

                case UsState.IA:
                    return "IOWA";

                case UsState.KS:
                    return "KANSAS";

                case UsState.KY:
                    return "KENTUCKY";

                case UsState.LA:
                    return "LOUISIANA";

                case UsState.ME:
                    return "MAINE";

                case UsState.MH:
                    return "MARSHALL ISLANDS";

                case UsState.MD:
                    return "MARYLAND";

                case UsState.MA:
                    return "MASSACHUSETTS";

                case UsState.MI:
                    return "MICHIGAN";

                case UsState.MN:
                    return "MINNESOTA";

                case UsState.MS:
                    return "MISSISSIPPI";

                case UsState.MO:
                    return "MISSOURI";

                case UsState.MT:
                    return "MONTANA";

                case UsState.NE:
                    return "NEBRASKA";

                case UsState.NV:
                    return "NEVADA";

                case UsState.NH:
                    return "NEW HAMPSHIRE";

                case UsState.NJ:
                    return "NEW JERSEY";

                case UsState.NM:
                    return "NEW MEXICO";

                case UsState.NY:
                    return "NEW YORK";

                case UsState.NC:
                    return "NORTH CAROLINA";

                case UsState.ND:
                    return "NORTH DAKOTA";

                case UsState.MP:
                    return "NORTHERN MARIANA ISLANDS";

                case UsState.OH:
                    return "OHIO";

                case UsState.OK:
                    return "OKLAHOMA";

                case UsState.OR:
                    return "OREGON";

                case UsState.PW:
                    return "PALAU";

                case UsState.PA:
                    return "PENNSYLVANIA";

                case UsState.PR:
                    return "PUERTO RICO";

                case UsState.RI:
                    return "RHODE ISLAND";

                case UsState.SC:
                    return "SOUTH CAROLINA";

                case UsState.SD:
                    return "SOUTH DAKOTA";

                case UsState.TN:
                    return "TENNESSEE";

                case UsState.TX:
                    return "TEXAS";

                case UsState.UT:
                    return "UTAH";

                case UsState.VT:
                    return "VERMONT";

                case UsState.VI:
                    return "VIRGIN ISLANDS";

                case UsState.VA:
                    return "VIRGINIA";

                case UsState.WA:
                    return "WASHINGTON";

                case UsState.WV:
                    return "WEST VIRGINIA";

                case UsState.WI:
                    return "WISCONSIN";

                case UsState.WY:
                    return "WYOMING";
            }

            throw new Exception("Unknown State Enum");

        }

        public static UsState GetStateByName(string name)
        {
            switch (name.ToUpper())
            {
                case "ALABAMA":
                    return UsState.AL;

                case "ALASKA":
                    return UsState.AK;

                case "AMERICAN SAMOA":
                    return UsState.AS;

                case "ARIZONA":
                    return UsState.AZ;

                case "ARKANSAS":
                    return UsState.AR;

                case "CALIFORNIA":
                    return UsState.CA;

                case "COLORADO":
                    return UsState.CO;

                case "CONNECTICUT":
                    return UsState.CT;

                case "DELAWARE":
                    return UsState.DE;

                case "DISTRICT OF COLUMBIA":
                    return UsState.DC;

                case "FEDERATED STATES OF MICRONESIA":
                    return UsState.FM;

                case "FLORIDA":
                    return UsState.FL;

                case "GEORGIA":
                    return UsState.GA;

                case "GUAM":
                    return UsState.GU;

                case "HAWAII":
                    return UsState.HI;

                case "IDAHO":
                    return UsState.ID;

                case "ILLINOIS":
                    return UsState.IL;

                case "INDIANA":
                    return UsState.IN;

                case "IOWA":
                    return UsState.IA;

                case "KANSAS":
                    return UsState.KS;

                case "KENTUCKY":
                    return UsState.KY;

                case "LOUISIANA":
                    return UsState.LA;

                case "MAINE":
                    return UsState.ME;

                case "MARSHALL ISLANDS":
                    return UsState.MH;

                case "MARYLAND":
                    return UsState.MD;

                case "MASSACHUSETTS":
                    return UsState.MA;

                case "MICHIGAN":
                    return UsState.MI;

                case "MINNESOTA":
                    return UsState.MN;

                case "MISSISSIPPI":
                    return UsState.MS;

                case "MISSOURI":
                    return UsState.MO;

                case "MONTANA":
                    return UsState.MT;

                case "NEBRASKA":
                    return UsState.NE;

                case "NEVADA":
                    return UsState.NV;

                case "NEW HAMPSHIRE":
                    return UsState.NH;

                case "NEW JERSEY":
                    return UsState.NJ;

                case "NEW MEXICO":
                    return UsState.NM;

                case "NEW YORK":
                    return UsState.NY;

                case "NORTH CAROLINA":
                    return UsState.NC;

                case "NORTH DAKOTA":
                    return UsState.ND;

                case "NORTHERN MARIANA ISLANDS":
                    return UsState.MP;

                case "OHIO":
                    return UsState.OH;

                case "OKLAHOMA":
                    return UsState.OK;

                case "OREGON":
                    return UsState.OR;

                case "PALAU":
                    return UsState.PW;

                case "PENNSYLVANIA":
                    return UsState.PA;

                case "PUERTO RICO":
                    return UsState.PR;

                case "RHODE ISLAND":
                    return UsState.RI;

                case "SOUTH CAROLINA":
                    return UsState.SC;

                case "SOUTH DAKOTA":
                    return UsState.SD;

                case "TENNESSEE":
                    return UsState.TN;

                case "TEXAS":
                    return UsState.TX;

                case "UTAH":
                    return UsState.UT;

                case "VERMONT":
                    return UsState.VT;

                case "VIRGIN ISLANDS":
                    return UsState.VI;

                case "VIRGINIA":
                    return UsState.VA;

                case "WASHINGTON":
                    return UsState.WA;

                case "WEST VIRGINIA":
                    return UsState.WV;

                case "WISCONSIN":
                    return UsState.WI;

                case "WYOMING":
                    return UsState.WY;
                default:
                    return UsState.Unknown;
            }
        }

        public static UsState GetUsStateBy(int areaCode)
        {
            var fullStateName = AreaCodeStateMapper.GetFullStateNameBy(areaCode);

            return GetStateByName(fullStateName);
        }
    }
}
