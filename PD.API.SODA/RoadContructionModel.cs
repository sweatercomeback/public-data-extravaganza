using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace  PD.API.SODA
{
    public class RoadContructionModel
    {
        public string Record { get; set; }

        public int Length { get;  set; }
        public string Type { get;  set; }
        public string Inventory { get;  set; }
        public int Begin_Sta { get;  set; }
        public int End_Sta { get;  set; }

        public string Structure { get;  set; }
        //public string Rtype1 { get;  set; }
        //public string Rtype2 { get;  set; }
        //public string Rtype3 { get;  set; }
        //public string Rtype4 { get;  set; }
        //public string Rtype5 { get;  set; }
        //public string Rtype6 { get;  set; }
        //public string Rtype7 { get;  set; }
        //public string Rtype8 { get;  set; }
        //public string Rtype9 { get;  set; }
        //public string Rtype10 { get;  set; }
        //public string Rtype11 { get;  set; }
        //public string Rtype12 { get;  set; }
        //public string Rtype13 { get;  set; }
        //public string Rtype14 { get;  set; }
        //public string Rtype15 { get;  set; }


        public string Route { get; set; }
        //public string Route1 { get;  set; }
        //public string Route2 { get;  set; }
        //public string Route3 { get;  set; }
        //public string Route4 { get;  set; }
        //public string Route5 { get;  set; }
        //public string Route6 { get;  set; }
        //public string Route7 { get;  set; }
        //public string Route8 { get;  set; }
        //public string Route9 { get;  set; }
        //public string Route10 { get;  set; }
        //public string Route11 { get;  set; }
        //public string Route12 { get;  set; }
        //public string Route13 { get;  set; }
        //public string Route14 { get;  set; }
        //public string Route15 { get;  set; }


        public string CountyName { get; set; }
        public string MILES_FMT { get;  set; }
        public int EST_COST_F { get;  set; }
        public int YRS_IN_PGM { get;  set; }


        //public string Location1 { get;  set; }
        //public string Location2 { get;  set; }
        //public string Location3 { get;  set; }
        //public string Location4 { get;  set; }
        //public string Location5 { get;  set; }
        //public string Location6 { get;  set; }
        //public string Location7 { get;  set; }
        //public string Location8 { get;  set; }
        //public string Location9 { get;  set; }
        //public string Location10 { get;  set; }
        //public string Location11 { get;  set; }
        //public string Location12 { get;  set; }
        //public string Location13 { get;  set; }
        //public string Location14 { get;  set; }

        public string Location { get; set; }
        public string Improvement { get; set; }

        //public string IMPRVMNT1 { get;  set; }
        //public string IMPRVMNT2 { get;  set; }
        //public string IMPRVMNT3 { get;  set; }
        //public string IMPRVMNT4 { get;  set; }
        //public string IMPRVMNT5 { get;  set; }
        //public string IMPRVMNT6 { get;  set; }
        //public string IMPRVMNT7 { get;  set; }
        //public string IMPRVMNT8 { get;  set; }
        //public string IMPRVMNT9 { get;  set; }
        //public string IMPRVMNT10 { get;  set; }
        //public string IMPRVMNT11 { get;  set; }
        //public string IMPRVMNT12 { get;  set; }
        //public string IMPRVMNT13 { get;  set; }
        //public string IMPRVMNT14 { get;  set; }
        //public string IMPRVMNT15 { get;  set; }


       
        

        //public string FOOTNOTES1 { get;  set; }
        //public string FOOTNOTES2 { get;  set; }
        //public string FOOTNOTES3 { get;  set; }
        //public string FOOTNOTES4 { get;  set; }
        //public string FOOTNOTES5 { get;  set; }
        //public string FOOTNOTES6 { get;  set; }
        //public string FOOTNOTES7 { get;  set; }
        //public string FOOTNOTES8 { get;  set; }
        //public string FOOTNOTES9 { get;  set; }
    
        //public string PRJ_REC_TY { get;  set; }
        //public string PPS_PROJEC { get;  set; }
        //public string PUB_DESC { get;  set; }
        
        public string Year { get;  set; }
        public int LOC_DIST_N { get;  set; }
        
        //public string TRACDESC1 { get;  set; }
        //public string TRACDESC2 { get;  set; }

        //public string TRACDESC3 { get;  set; }
        //public string TRACDESC4 { get;  set; }
        //public string TRACDESC5 { get;  set; }
        //public string TRACDESC6 { get;  set; }
        //public string TRACDESC7 { get;  set; }
        //public string TRACDESC8 { get;  set; }
        //public string TRACDESC9 { get;  set; }
        //public string TRACDESC10 { get;  set; }

        public float Longitude { get; set; }
        public float Latitude { get; set; }

        public string Description { get; set; }

        /*
         * Column name:LENGTH:	 Type:number
Column name:TYPE:	 Type:text
Column name:INVENTORY:	 Type:texte
Column name:END_STA:	 Type:number
Column name:STRUCTURE_:	 Type:text
Column name:RTYPE1:	 Type:text
Column name:RTYPE2:	 Type:text
Column name:RTYPE3:	 Type:text
Column name:RTYPE4:	 Type:text
Column name:RTYPE5:	 Type:text
Column name:RTYPE6:	 Type:text
Column name:RTYPE7:	 Type:text
Column name:RTYPE8:	 Type:text
Column name:RTYPE9:	 Type:text
Column name:RTYPE10:	 Type:text
Column name:RTYPE11:	 Type:text
Column name:RTYPE12:	 Type:text
Column name:RTYPE13:	 Type:text
Column name:RTYPE14:	 Type:text
Column name:RTYPE15:	 Type:text
Column name:ROUTE1:	 Type:text
Column name:ROUTE2:	 Type:text
Column name:ROUTE3:	 Type:text
Column name:ROUTE4:	 Type:text
Column name:ROUTE5:	 Type:text
Column name:ROUTE6:	 Type:text
Column name:ROUTE7:	 Type:text
Column name:ROUTE8:	 Type:text
Column name:ROUTE9:	 Type:text
Column name:ROUTE10:	 Type:text
Column name:ROUTE11:	 Type:text
Column name:ROUTE12:	 Type:text
Column name:ROUTE13:	 Type:text
Column name:ROUTE14:	 Type:text
Column name:ROUTE15:	 Type:text
Column name:COUNTY_NAM:	 Type:text
Column name:MILES_FMT:	 Type:text
Column name:EST_COST_F:	 Type:number
Column name:YRS_IN_PGM:	 Type:number
Column name:LOCATION1:	 Type:text
Column name:LOCATION2:	 Type:text
Column name:LOCATION3:	 Type:text
Column name:LOCATION4:	 Type:text
Column name:LOCATION5:	 Type:text
Column name:LOCATION6:	 Type:text
Column name:LOCATION7:	 Type:text
Column name:LOCATION8:	 Type:text
Column name:LOCATION9:	 Type:text
Column name:LOCATION10:	 Type:text
Column name:LOCATION11:	 Type:text
Column name:LOCATION12:	 Type:text
Column name:LOCATION13:	 Type:text
Column name:LOCATION14:	 Type:text
Column name:IMPRVMNT1:	 Type:text
Column name:IMPRVMNT2:	 Type:text
Column name:IMPRVMNT3:	 Type:text
Column name:IMPRVMNT4:	 Type:text
Column name:IMPRVMNT5:	 Type:text
Column name:IMPRVMNT6:	 Type:text
Column name:IMPRVMNT7:	 Type:text
Column name:IMPRVMNT8:	 Type:text
Column name:IMPRVMNT9:	 Type:text
Column name:IMPRVMNT10:	 Type:text
Column name:IMPRVMNT11:	 Type:text
Column name:IMPRVMNT12:	 Type:text
Column name:IMPRVMNT13:	 Type:text
Column name:IMPRVMNT14:	 Type:text
Column name:IMPRVMNT15:	 Type:text
Column name:FOOTNOTES1:	 Type:text
Column name:FOOTNOTES2:	 Type:text
Column name:FOOTNOTES3:	 Type:text
Column name:FOOTNOTES4:	 Type:text
Column name:FOOTNOTES5:	 Type:text
Column name:FOOTNOTES6:	 Type:text
Column name:FOOTNOTES7:	 Type:text
Column name:FOOTNOTES8:	 Type:text
Column name:FOOTNOTES9:	 Type:text
Column name:PRJ_REC_TY:	 Type:text
Column name:PPS_PROJEC:	 Type:text
Column name:PUB_DESC:	 Type:text
Column name:RECORD:	 Type:text
Column name:YEAR:	 Type:text
Column name:LOC_DIST_N:	 Type:number
Column name:TRACDESC1:	 Type:text
Column name:TRACDESC2:	 Type:text
Column name:TRACDESC3:	 Type:text
Column name:TRACDESC4:	 Type:text
Column name:TRACDESC5:	 Type:text
Column name:TRACDESC6:	 Type:text
Column name:TRACDESC7:	 Type:text
Column name:TRACDESC8:	 Type:text
Column name:TRACDESC9:	 Type:text
Column name:TRACDESC10:	 Type:text
Column name:POINT_X:	 Type:number
Column name:POINT_Y:	 Type:number
         */

    }
}