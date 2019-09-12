﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassWordApp.Models
{
    public class DBManager
    {
        /// <summary>
        /// Adds a new password record.
        /// </summary>
        /// <param name="p">The password object.</param>
        public void Add(PassWord p)
        {
            p.PassWordId = DB.LastId++;

            DB.passWordList.Add(p);
        }

        public List<PassWord> GetAll()
        {
            return DB.passWordList;
        }

        public void Delete(int id)
        {
            DB.passWordList.Remove(Details(id));
        }

        public PassWord Details(int id)
        {
            return DB.passWordList.Where(x => x.PassWordId == id).Single();
        }

        public void Update(PassWord p)
        {
            //
        }

    }
}