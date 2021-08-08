-- Ürün Yönetimi işlemi

- ilk olarak "Abstract" isminde bir klasör ve bu klasör içerisine "BaseClass" isminde bir class oluşturun. Bu class'ı oluşturma sebebimiz; her bir class'da kullanılacak ortak property(özelliklerini) barındırmasıdır.

- "Class" isminde bir klasör oluşturun. Bu klasör içerisinde Product ve Category isminde iki ayrı class tanımlayın. Her bir class "BaseClass" dan miras almalı. Oluşturulan classlar içerisinde constructor'ı ezerek "CreatedDate" özelliğini şuanki zaman olarak atayın. Bunun sebebi ise; alınan instance (örnek) ile beraber tekrar tekrar oluşturulma tarihini doldurmak istemediğimiz içindir. 

- "Data" isminde bir klasör oluşturup içerisinde "Database" isminde bir class tanımlayın. Bu class veritabanını temsil edecek. İçerisinde ise 2 adet static Property bulunmalı. Bunlardan ilki categories ikincisi products. Amacımız ise eklemiş olduğumuz ürünleri ve kategorileri uygulama içerisinde herhangi bir yerden ulaşmak ve verileri dilediğimiz gibi kullanmaktır. categories isimli liste de örnek 3 adet kategori tanımlanmalı ki uygulama açıldığında Form içerisinde bulunan comboboxta listelenmeli.

- "Interface" adında bir klasör oluşturun. Bu klasör bütün classlarda kullanılacak eylemleri barındırmalı. Örneğin bütün classlarda ortak olarak kullanılacak bazı metotlar bulunur. Bunlar; ekleme, listeleme, silme ve güncelleme. Bu yüzden her bir class'a karşılık gelecek bir interface olmalı ki tek bir elden yönetim imkanını sahip olabilelim.


