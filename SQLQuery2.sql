--Select: Veri kaynağından veriyi çekmek için kullanılan koddur.
-- "*" Kolonlar anlamına gelir.
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
-- where koşul(filtreleme özelleştirme) olarak geçer.Sorgu olarakta kullanırız.
Select * from Customers where City = 'London'
--case insensitive(harf duyarsızlığı vardır. istediğimiz şekilde yazabiliriz.
select * from Products where categoryId= 1 or categoryId=3
select * from Products where categoryId= 1 and UnitPrice >=10

--order by: sırala anlamına gelir.
--ascending(asc) artan sıraya göre 
--descending(desc) azalan sıraya göre
select *from Products where categoryId=1 order by UnitPrice asc
select *from Products order by UnitPrice desc

--count(*): Tüm satırların sayısını verir. Her satır bir ürüne denk gelir.Sonuçta ürün sayısını verir.
-- yanına herhangi bir kolon alamaz.

Select count(*) Adet  from Products where categoryId=2

-- group by kullandığımız zaman sadece tek grup olur. gruplandırmak için kullanılır.
--group by kullandığımız zaman select ettiğimiz ifade * olamaz group by a tanımladığımız ifadeyi select etmemiz gerekir. Sonrasında count(*) ekleyebiliriz.
--group by yaptığımız için her satır için arka planda ayrı bir grup oluşturulur diyebiliriz.
--having group by a sorgu olarak yazılır where yerine geçer.
Select categoryId, count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10	 

--inner join:Sdece 2 tablodaki eşleşenleri bir araya getirir. Bir araya getirmek anlamına gelir. Koşul için on kullanılır.
select * 
from products inner join categories
on Products.CategoryID = Categories.CategoryID

--[] tablo olarak almaya yarıyor.
Select * from Products p inner join [Order Details] od
on p.ProductID= od.ProductID






