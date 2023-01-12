using for2023work.算法;
using for2023work.设计模式;
using for2023work.面向对象;

LRU test = new LRU();
test.AddName("cookie");
test.AddName("branly");
test.AddName("allen");
test.ShowLastestPersonalNames();
test.GetName("branly");
test.ShowLastestPersonalNames();