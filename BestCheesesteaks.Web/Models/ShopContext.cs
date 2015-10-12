using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BestCheesesteaks.Web.Models
{

  public class ShopContext : DbContext
  {

    public DbSet<Shop> Shops { get; set; }

  }

  public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
  {

    protected override void Seed(ShopContext context)
    {

      context.Shops.Add(new Shop()
      {Address= "14 Snyder Ave",
      Address2="Philadelphia, PA 19148",
      Id= "johns-roast-pork-philadelphia",
      ImageUrl= "http://s3-media4.fl.yelpcdn.com/bphoto/5K5qHwu54yQdSPX0D5F7LQ/ms.jpg",
      Lat= 39.921077022998M,
      Lon= -75.145013867161M,
      Name= "John's Roast Pork",
      Phone= "+1-215-463-1951",
      Rating= 4.5M,
      RatingUrl= "http://s3-media2.fl.yelpcdn.com/assets/2/www/img/99493c12711e/ico/stars/v1/stars_4_half.png",
      Review_Count=582
      });
      context.Shops.Add(new Shop()
      {
        Address= "Reading Terminal Market",
        Address2= "Philadelphia, PA 19147",
        Id= "tommy-dinics-philadelphia",
        ImageUrl= "http://s3-media1.fl.yelpcdn.com/bphoto/dphtynZJtr-ZJQpFfoSX0w/ms.jpg",
        Lat= 39.9534051258312M,
        Lon= -75.1592838764191M,
        Name= "Tommy DiNic's",
        Phone= "215-923-6175",
        Rating=4.0M,
        RatingUrl= "http://s3-media4.fl.yelpcdn.com/assets/2/www/img/c2f3dd9799a5/ico/stars/v1/stars_4.png",
        Review_Count=1283
      });
      context.Shops.Add(new Shop()
      {
        Address = "228 Market St",
        Address2 = "Philadelphia, PA 19106",
        Id = "sonnys-famous-steaks-philadelphia",
        ImageUrl = "http://s3-media2.fl.yelpcdn.com/bphoto/zy4gyYIZ2dzILThIGlLRXw/ms.jpg",
        Lat = 39.9498023986816M,
        Lon = -75.1448059082031M,
        Name = "Sonny's Famous Steaks",
        Phone = "215-629-5760",
        Rating = 4.0M,
        RatingUrl = "http://s3-media4.fl.yelpcdn.com/assets/2/www/img/c2f3dd9799a5/ico/stars/v1/stars_4.png",
        Review_Count = 502
      });
      context.Shops.Add(new Shop()
      {
        Address = "152 W Girard Ave",
        Address2 = "Philadelphia, PA 19123",
        Id = "paesanos-philly-style-philadelphia-2",
        ImageUrl = "http://s3-media1.fl.yelpcdn.com/bphoto/OsYxQjIdIKaVN4CpvBZGug/ms.jpg",
        Lat = 39.9690589904785M,
        Lon = -75.1381454467773M,
        Name = "Paesano's Philly Style",
        Phone = "267-886-9556",
        Rating = 4.5M,
        RatingUrl = "http://s3-media2.fl.yelpcdn.com/assets/2/www/img/99493c12711e/ico/stars/v1/stars_4_half.png",
        Review_Count = 460
      });
      context.Shops.Add(new Shop()
      {
        Address = "39 E Oregon Ave",
        Address2 = "Philadelphia, PA 19148",
        Id = "tony-lukes-philadelphia",
        ImageUrl = "http://s3-media2.fl.yelpcdn.com/bphoto/bOOu2RO3GTMTdX236rCDSw/ms.jpg",
        Lat = 39.914271090261M,
        Lon = -75.14944069802M,
        Name = "Tony Luke's",
        Phone = "215-551-5725",
        Rating = 4.0M,
        RatingUrl = "http://s3-media4.fl.yelpcdn.com/assets/2/www/img/c2f3dd9799a5/ico/stars/v1/stars_4.png",
        Review_Count = 1068
      });
      context.Shops.Add(new Shop()
      {
        Address = "1237 E Passyunk Ave",
        Address2 = "Philadelphia, PA 19147",
        Id = "pats - king - of - steaks - philadelphia - 2",
        ImageUrl = "http://s3-media3.fl.yelpcdn.com/bphoto/k86-VQ5rsNg61PYMilFmhQ/ms.jpg",
        Lat = 39.9331439905731M,
        Lon = -75.1592865995506M,
        Name = "Pat's King of Steaks",
        Phone = "+1-215-468-1546",
        Rating = 3.5M,
        RatingUrl = "http://s3-media1.fl.yelpcdn.com/assets/2/www/img/5ef3eb3cb162/ico/stars/v1/stars_3_half.png",
        Review_Count = 2737
      });
      context.Shops.Add(new Shop()
      {
        Address = "400 South St",
        Address2 = "Philadelphia, PA 19147",
        Id = "jims-steaks-philadelphia-4",
        ImageUrl = "http://s3-media4.fl.yelpcdn.com/bphoto/mAOn8FmetDfMpglL6tY88g/ms.jpg",
        Lat = 39.941496M,
        Lon = -75.149315M,
        Name = "Jim's Steaks",
        Phone = "+1-215-928-1911",
        Rating = 3.5M,
        RatingUrl = "http://s3-media1.fl.yelpcdn.com/assets/2/www/img/5ef3eb3cb162/ico/stars/v1/stars_3_half.png",
        Review_Count = 1342
      });
      context.Shops.Add(new Shop()
      {
        Address = "600 Wendover St",
        Address2 = "Philadelphia, PA 19128",
        Id = "dalessandros-steaks-philadelphia",
        ImageUrl = "http://s3-media4.fl.yelpcdn.com/bphoto/cJ8nk33DHKNXImG1NAGT3g/ms.jpg",
        Lat = 40.02951M,
        Lon = -75.20599M,
        Name = "Dalessandro's Steaks",
        Phone = "+1-215-482-5407",
        Rating = 4.5M,
        RatingUrl = "http://s3-media2.fl.yelpcdn.com/assets/2/www/img/99493c12711e/ico/stars/v1/stars_4_half.png",
        Review_Count = 652
      });
      context.Shops.Add(new Shop()
      {
        Address = "1219 S 9th St",
        Address2 = "Philadelphia, PA 19147",
        Id = "genos-steaks-philadelphia",
        ImageUrl = "http://s3-media2.fl.yelpcdn.com/bphoto/y1_1EIdHcsE25X1yDUgFrQ/ms.jpg",
        Lat = 39.933723134559M,
        Lon = -75.158922700202M,
        Name = "Geno's Steaks",
        Phone = "+1-215-389-0659",
        Rating = 2.5M,
        RatingUrl = "http://s3-media4.fl.yelpcdn.com/assets/2/www/img/c7fb9aff59f9/ico/stars/v1/stars_2_half.png",
        Review_Count = 2179
      });

      context.SaveChanges();

    }

  }

}