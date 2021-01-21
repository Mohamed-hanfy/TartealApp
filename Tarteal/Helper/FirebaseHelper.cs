using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;

namespace Tarteal.Helper
{
       public class FirebaseHelper
        {
            FirebaseClient firebase = new FirebaseClient("https://quran-5e7dd.firebaseio.com/");

        public async Task<List<Quran>> Fakerr()
        {

            return (await firebase
              .Child("Faker")
              
               
              .OnceAsync<Quran>()).Select(item => new Quran
              {
                  Name = item.Object.Name,
                URL = item.Object.URL,
                                  
              }).ToList();
        }
        public async Task<List<Quran>> Kawaterr()
        {

            return (await firebase
              .Child("Kawater")


              .OnceAsync<Quran>()).Select(item => new Quran
              {
                  Name = item.Object.Name,
                  URL = item.Object.URL,
                
                 
              }).ToList();
        }
        public async Task<List<Quran>> motaa()
        {

            return (await firebase
              .Child("Motaa")


              .OnceAsync<Quran>()).Select(item => new Quran
              {
                  Name = item.Object.Name,
                  URL = item.Object.URL,
                  

         
              }).ToList();
        }
        public async Task<List<Quran>> Islam()
        {

            return (await firebase
              .Child("Q-IslamSopihe")
              .OnceAsync<Quran>()).Select(item => new Quran
              {
                  Name = item.Object.Name,
                  URL = item.Object.URL,
              }).ToList();
        }
        public async Task<List<Quran>> Palohy()
        {

            return (await firebase
              .Child("Q-Palohy")
              .OnceAsync<Quran>()).Select(item => new Quran
              {
                  Name = item.Object.Name,
                  URL = item.Object.URL,
              }).ToList();
        }


        public async Task<List<Quran>> Maherel()
        {

            return (await firebase
              .Child("Q-Maher")
              .OnceAsync<Quran>()).Select(item => new Quran
              {
                  Name = item.Object.Name,
                  URL = item.Object.URL,
              }).ToList();
        }
    }


}
