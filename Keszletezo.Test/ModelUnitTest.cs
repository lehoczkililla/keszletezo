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
        string path = "";
        string sep = ";";




        private List<Adat> getDataFromCsv(int sorszam = 0)
        {
            List<Adat> adatok = new List<Adat>();
            using (var reader = new StreamReader(path + DateTime.Now.ToString("yyyyMMdd") + "_" + sorszam + ".csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(sep);
                    Adat a = new Adat()
                    {

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
            model.kisebbmintot(new List<Adat>());
            var result = getDataFromCsv();
            Assert.Empty(result);
        }



        [Fact]
        public void Normal_Test()
        {
            //van bene 5-nél kisebb meg 5-nél nagyobb is, még 5-ös is legyen benne
            List<Adat> input = new List<Adat>() {
                new Adat() {

                },
                new Adat() {

                }
            };


            List<Adat> output = new List<Adat>(){
                new Adat(){

                },
                new Adat(){

                },

            };

            model = new Model();
            model.kisebbmintot(input);
            var result = getDataFromCsv();
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
            List<Adat> input = new List<Adat>() {
                new Adat() {

                },
                new Adat() {

                }
            };

            model = new Model();
            model.kisebbmintot(input);
            var result = getDataFromCsv();
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

                },
                new Adat() {

                }
            };

            model = new Model();
            model.kisebbmintot(input);
            var result = getDataFromCsv();
            Assert.Empty(result);

        }

        [Fact]
        public void TobbszoriLefuttatas_Test()
        {
            //van bene 5-nél kisebb meg 5-nél nagyobb is, még 5-ös is legyen benne
            List<Adat> input1 = new List<Adat>() {
                new Adat() {

                },
                new Adat() {

                }
            };


            List<Adat> output1 = new List<Adat>(){
                new Adat(){

                },
                new Adat(){

                },

            };

            List<Adat> input2 = new List<Adat>() {
                new Adat() {

                },
                new Adat() {

                }
            };


            List<Adat> output2 = new List<Adat>(){
                new Adat(){

                },
                new Adat(){

                },

            };

            model = new Model();
            model.kisebbmintot(input1);
            model.kisebbmintot(input2);


            var result = getDataFromCsv();
            Assert.Equal(output1.Count, result.Count);
            for (int i = 0; i < output1.Count; i++)
            {
                Assert.Contains(output1[i], result);
                Assert.Contains(result[i], output1);
            }

            result = getDataFromCsv(1);
            Assert.Equal(output2.Count, result.Count);
            for (int i = 0; i < output2.Count; i++)
            {
                Assert.Contains(output2[i], result);
                Assert.Contains(result[i], output2);
            }
        }
    }
}
