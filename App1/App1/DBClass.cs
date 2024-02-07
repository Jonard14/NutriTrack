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
using System.Text.Json;

namespace App1
{
    internal class DBClass
    {
        /*  Jonard Note:
            Nilagay ko dito para isahan edit ng IP Address
            Sa request, call this variable IP_DB then lagyan nalang ng plus 
            e.g. (HttpWebRequest)WebRequest.Create(IP_DB + "update.php?name=" + name + "&status=" + status)
         */
        string IP_DB = "http://192.168.100.17/CS134P-1P-Thesis/";

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

        public string InsertData(string WebReq)
        {
            request = (HttpWebRequest)WebRequest.Create(IP_DB + WebReq);
            response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            res = reader.ReadToEnd();
            return res;
        }

        public JsonElement RetrieveData(string WebReq)
        {
            request = (HttpWebRequest)WebRequest.Create(IP_DB + WebReq);
            response = (HttpWebResponse)request.GetResponse();
            res = response.ProtocolVersion.ToString();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var result = reader.ReadToEnd();
            using JsonDocument doc = JsonDocument.Parse(result);
            JsonElement root = doc.RootElement.Clone();
            return root;
        }
    }
}

/* DATABASE
CREATE DATABASE USER_DB;
USE USER_DB;

CREATE TABLE `LOGIN` (
  `email` VARCHAR(40),
  `password` VARCHAR(40),
  PRIMARY KEY (`email`)
);

CREATE TABLE `USER_DATA` (
  `email` VARCHAR(40),
  `first_name` VARCHAR(30),
  `last_name` VARCHAR(20),
  `age` INTEGER,
  `height` DECIMAL,
  `weight` DECIMAL,
  `bmi` VARCHAR(15),
  `daily_calorie_intake` DECIMAL,
  `gender` VARCHAR(1)
);

CREATE TABLE `ILLNESSES` (
  `first_name` VARCHAR(30),
  `types` VARCHAR(30)
);

CREATE DATABASE FOOD_DB;
USE FOOD_DB;

CREATE TABLE `FOOD_DATA` (
  `food-id` VARCHAR(6),
  `food_name` VARCHAR(20),
  `food_desc` TEXT,
  PRIMARY KEY (`food-id`)
);

CREATE TABLE `BRANDS` (
  `food_id` VARCHAR(6),
  `brand_id` VARCHAR(6),
  `food_brand` VARCHAR(20),
  PRIMARY KEY (`brand_id`)
);

CREATE TABLE `MACRONUTRIENTS` (
  `brand_id` VARCHAR(6),
  `macronutrients` VARCHAR(20)
);

CREATE TABLE `MICRONUTRIENTS` (
  `brand_id` VARCHAR(6),
  `mIcronutrients` VARCHAR(20)
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