using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSystem.Models
{
    public class GameProvider:IProvider<GameInfo>
    {
        private WebSiteEntities db = new WebSiteEntities();
        public int Delete(GameInfo t)
        {
            if (t == null) return 0;
            var model = db.GameInfo.ToList().FirstOrDefault(item => item.Id == t.Id);
            if (model == null) return 0;
            db.GameInfo.Remove(model);
            int count = db.SaveChanges();
            return count;
        }

        public int Insert(GameInfo t)
        {
            if (t == null) return 0;
            db.GameInfo.Add(t);
            int count = db.SaveChanges();
            return count;
        }

        public List<GameInfo> Select()
        {
            return db.GameInfo.ToList();
        }
        public int Update(GameInfo t)
        {
            if (t == null) return 0;
            var model = db.GameInfo.ToList().FirstOrDefault(item => item.Id == t.Id);
            if (model == null) return 0;
            model.GameName = t.GameName;
            model.GameImg1 = t.GameImg1;
            model.GameImg2 = t.GameImg2;
            model.Introduction = t.Introduction;
            model.Slogan1 = t.Slogan1;
            model.Slogan2 = t.Slogan2;
            model.Video = t.Video;
            model.GameIndexUrl = t.GameIndexUrl;
            int count = db.SaveChanges();
            return count;

        }
    }
}