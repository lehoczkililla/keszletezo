using Xunit;
using keszletezo.Model;
using System.Collections.Generic;
using System.IO;
using System;

namespace Test
{
    public class ModelTest
    {
        Model model;
        string sep = ";";

        private List<Adat> getDataFromCsv(string path)
        {
            List<Adat> adatok = new List<Adat>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(sep);
                    Adat a = new Adat()
                    {
                        bvin = values[0],
                        ProductBvin = values[1],
                        VariantId = values[2],
                        QuantityOnHand = Convert.ToInt32(values[3]),
                        QuantityReserved = Convert.ToInt32(values[4]),
                        QuantityAvailableForSale = Convert.ToInt32(values[5]),
                        LowStockPoint = Convert.ToInt32(values[6]),
                        LastUpdated = Convert.ToDateTime(values[7]),
                        StoreId = Convert.ToInt64(values[8]),
                        OutOfStockPoint = Convert.ToInt32(values[9])
                    };
                    adatok.Add(a);
                }
            }
            return adatok;
        }

        [Fact]
        public void Empty_Test()
        {
            model = new Model();
            string csvpath = model.kisebbmintot(new List<Adat>());
            var result = getDataFromCsv(csvpath);
            Assert.Empty(result);
        }



        [Fact]
        public void Normal_Test()
        {
            //van bene 5-nél kisebb meg 5-nél nagyobb is, még 5-ös is legyen benne
            List<Adat> input = new List<Adat>() {
                new Adat() {
                    bvin = "test_b1",
                    ProductBvin = "test_pb1",
                    VariantId = "test_vi1",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 5,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5
                },
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b3",
                    ProductBvin = "test_pb3",
                    VariantId = "test_vi3",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 7,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b4",
                    ProductBvin = "test_pb4",
                    VariantId = "test_vi4",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 6,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b5",
                    ProductBvin = "test_pb5",
                    VariantId = "test_vi5",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }
            };


            List<Adat> output = new List<Adat>(){
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b5",
                    ProductBvin = "test_pb5",
                    VariantId = "test_vi5",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }
        };

            model = new Model();
            string csvpath  = model.kisebbmintot(input);
            var result = getDataFromCsv(csvpath);
            Assert.Equal(output.Count, result.Count);
            for (int i = 0; i < output.Count; i++)
            {
                Assert.Contains(output[i], result);
                Assert.Contains(result[i], output);
            }
        }

        [Fact]
        public void CsakKicsi_Test()
        {
            //csak 5nél kisebbek legyenek benne
            List<Adat> input = new List<Adat>(){
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b8",
                    ProductBvin = "test_pb8",
                    VariantId = "test_vi8",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 4,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b5",
                    ProductBvin = "test_pb5",
                    VariantId = "test_vi5",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }
        };

            model = new Model();
            string csvpath = model.kisebbmintot(input);
            var result = getDataFromCsv(csvpath);
            Assert.Equal(input.Count, result.Count);
            for (int i = 0; i < input.Count; i++)
            {
                Assert.Contains(input[i], result);
                Assert.Contains(result[i], input);
            }
        }

        [Fact]
        public void CsakNagyobb_Test()
        {
            //csak 5nél nagyobbak legyenek benne
            List<Adat> input = new List<Adat>() {
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 5,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 8,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 6,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }
            };

            model = new Model();
            string csvpath = model.kisebbmintot(input);
            var result = getDataFromCsv(csvpath);
            Assert.Empty(result);

        }

        [Fact]
        public void TobbszoriLefuttatas_Test()
        {
            //van bene 5-nél kisebb meg 5-nél nagyobb is, még 5-ös is legyen benne
            List<Adat> input1 = new List<Adat>() {
                        new Adat() {
                    bvin = "test_b1",
                    ProductBvin = "test_pb1",
                    VariantId = "test_vi1",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 5,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5
                },
                new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b3",
                    ProductBvin = "test_pb3",
                    VariantId = "test_vi3",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 7,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b4",
                    ProductBvin = "test_pb4",
                    VariantId = "test_vi4",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 6,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b5",
                    ProductBvin = "test_pb5",
                    VariantId = "test_vi5",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }
            };


            List<Adat> output1 = new List<Adat>(){
                  new Adat() {
                    bvin = "test_b2",
                    ProductBvin = "test_pb2",
                    VariantId = "test_vi2",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b5",
                    ProductBvin = "test_pb5",
                    VariantId = "test_vi5",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }

            };

            List<Adat> input2 = new List<Adat>() {
                 new Adat() {
                    bvin = "test_b12",
                    ProductBvin = "test_pb12",
                    VariantId = "test_vi12",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 4,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5
                },
                new Adat() {
                    bvin = "test_b22",
                    ProductBvin = "test_pb22",
                    VariantId = "test_vi22",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b32",
                    ProductBvin = "test_pb32",
                    VariantId = "test_vi32",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 5,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b42",
                    ProductBvin = "test_pb42",
                    VariantId = "test_vi42",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 6,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b52",
                    ProductBvin = "test_pb52",
                    VariantId = "test_vi52",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }
            };


            List<Adat> output2 = new List<Adat>(){
                new Adat() {
                    bvin = "test_b12",
                    ProductBvin = "test_pb12",
                    VariantId = "test_vi12",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 4,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5
                },
                new Adat() {
                    bvin = "test_b22",
                    ProductBvin = "test_pb22",
                    VariantId = "test_vi22",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 2,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                },
                new Adat() {
                    bvin = "test_b52",
                    ProductBvin = "test_pb52",
                    VariantId = "test_vi52",
                    QuantityOnHand = 5,
                    QuantityReserved = 0,
                    QuantityAvailableForSale = 1,
                    LowStockPoint = 5,
                    LastUpdated = new DateTime(2023,05,01),
                    StoreId = 5,
                    OutOfStockPoint = 5,
                }

            };

            model = new Model();
            string csvpath1 = model.kisebbmintot(input1);
            string csvpath2 = model.kisebbmintot(input2);


            var result = getDataFromCsv(csvpath1);
            Assert.Equal(output1.Count, result.Count);
            for (int i = 0; i < output1.Count; i++)
            {
                Assert.Contains(output1[i], result);
                Assert.Contains(result[i], output1);
            }

            result = getDataFromCsv(csvpath2);
            Assert.Equal(output2.Count, result.Count);
            for (int i = 0; i < output2.Count; i++)
            {
                Assert.Contains(output2[i], result);
                Assert.Contains(result[i], output2);
            }
        }
    }
}
