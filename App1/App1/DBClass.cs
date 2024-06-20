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
        //string IP_DB = "http://192.168.61.210/CS134P-1P-Thesis/";
        //string IP_DB = "http://192.168.100.17/CS134P-1P-Thesis/";
        string IP_DB = "http://192.168.100.5/CS134P-1P-Thesis/";
        //string IP_DB = "http://192.168.137.1/CS134P-1P-Thesis/";

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
            request.Abort();
            return res;
        }

        public string InsertData(string WebReq)
        {
            request = (HttpWebRequest)WebRequest.Create(IP_DB + WebReq);
            response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            res = reader.ReadToEnd();
            request.Abort();
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
            request.Abort();
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
  `height` decimal(10,2),
  `weight` decimal(10,2),
  `bmi` VARCHAR(15),
  `daily_calorie_intake` decimal(10,2),
  `gender` VARCHAR(1),
  PRIMARY KEY (`email`)
);

CREATE TABLE `ILLNESSES` (
  `email` VARCHAR(40),
  `types` TEXT
);

CREATE TABLE `USER_FOOD` (
  `email` VARCHAR(40),
  `date` DATE,
  `food_name` VARCHAR(20),
  `macronutrients` decimal(10,2),
  `micronutrients` decimal(10,2)
);

CREATE DATABASE FOOD_DB;
USE FOOD_DB;

CREATE TABLE `FOOD_DATA` (
  `food_id` VARCHAR(6),
  `food_name` VARCHAR(50),
  PRIMARY KEY (`food_id`)
);

CREATE TABLE `NUTRIENTS` (
  `food_id` VARCHAR(6),
  `calorie_energy` FLOAT,
  `protein` FLOAT,
  `total_fat` FLOAT,
  `carbohydrate` FLOAT,
  `sugar` FLOAT,
  `sodium` FLOAT,
  `cholesterol` FLOAT
);
*/