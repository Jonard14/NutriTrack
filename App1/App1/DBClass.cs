using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace GROUP7_IT123P_MP
{
    internal class DBClass
    {
        /*  Jonard Note:
            Nilagay ko dito para isahan edit ng IP Address
            Sa request, call this variable IP_DB then lagyan nalang ng plus 
            e.g. (HttpWebRequest)WebRequest.Create(IP_DB + "update.php?name=" + name + "&status=" + status)
         */
        string IP_DB = "http://192.168.100.17/DatabaseName/";

        //Http Response
        HttpWebResponse response;
        HttpWebRequest request;
        string res;

        public string UpdateStatus(string WebReq)
        {
            request = (HttpWebRequest)WebRequest.Create(IP_DB + WebReq);
            response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            res = reader.ReadToEnd();
            return res;
        }

        public HttpWebResponse RetrieveData(string WebReq)
        {
            request = (HttpWebRequest)WebRequest.Create(IP_DB + WebReq);
            response = (HttpWebResponse)request.GetResponse();
            res = response.ProtocolVersion.ToString();
            return response;

        }
    }
}

/* 
Table of 'login'
CREATE TABLE `LOGIN` (
  `email` VARCHAR(20),
  `password` VARCHAR(20),
  PRIMARY KEY (`email`)
);

CREATE TABLE `USER_DATA` (
  `email` VARCHAR(20),
  `first_name` VARCHAR(30),
  `last_name` VARCHAR(20),
  `age` INTEGER,
  `height` DECIMAL,
  `weight` DECIMAL,
  `bmi` VARCHAR(15),
  `daily_calorie_intake` DECIMAL
);

CREATE TABLE `ILLNESSES` (
  `types` VARCHAR(30)
);
*/

/* retreive data via json
            DBClass response = new DBClass();
            HttpWebResponse res = response.RetrieveData("search_record.php");
            StreamReader reader = new StreamReader(res.GetResponseStream());
            var result = reader.ReadToEnd();
            using JsonDocument doc = JsonDocument.Parse(result);
            JsonElement root = doc.RootElement;

            List<string> title = new List<string>();
            List<string> imageFiles = new List<string>(); //empty lists for desc and imgfile
            List<string> desc = new List<string>();
            List<string> ingredients = new List<string>();
            List<string> steps = new List<string>();

            for (int i = 0; i < root.GetArrayLength(); i++) //loops through the database and assign it in a variable
            {
                var u1 = root[i];

                string searchedname = u1.GetProperty("name").ToString();
                string searchedimgfile = u1.GetProperty("imgfile").ToString();
                string searcheddesc = u1.GetProperty("description").ToString();
                string searchedingredients = u1.GetProperty("ingredients").ToString();
                string searchedsteps = u1.GetProperty("steps").ToString();

                title.Add(searchedname);
                imageFiles.Add(searchedimgfile); //added imgfile and desc in the lists
                desc.Add(searcheddesc);
                ingredients.Add(searchedingredients);
                steps.Add(searchedsteps);
            }
            string[] titleArray = title.ToArray();
            string[] imgArray = imageFiles.ToArray(); //converted the lists to an array and then assign it in the parameters for randclass
            string[] descArray = desc.ToArray();
            string[] ingredientsArray = ingredients.ToArray();
            string[] stepsArray = steps.ToArray();

            //Calls Randomizer class
            randclass = new Randomizer(iv, dish_title_tv, dish_desc_tv, titleArray, descArray, imgArray, ingredientsArray, stepsArray);
            //Randomize content when the user opens the app
            randclass.startup();
            //Runs the content randomly every 10 seconds
            randclass.Play();
*/