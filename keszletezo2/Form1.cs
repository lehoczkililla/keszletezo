using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace keszletezo2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void letoltes_Click(object sender, EventArgs e)
        {
            Hova hova = new Hova();
            if (hova.ShowDialog() == DialogResult.OK)
            {

                progressBar1.Visible = true;

                Api proxy = apiHivas();
                string path = hova.pathBox.Text;
                var file = path + "myOutput.csv";
                //írjuk ki a fájlba
                using (var stream = File.CreateText(file))
                {

                    for (int i = 0; i < 178; i++)
                    {
                        string inventoryId = inventory[i];
                        var inv = proxy.ProductInventoryFind(inventoryId);
                        if (i == 0)
                        {
                            string fejlec = string.Format("{0};{1}", "Termékazonosító", "Mennyiség");
                            stream.WriteLine(fejlec);
                        }
                        if (inv.Content.QuantityOnHand < 5)
                        {
                            string first = inv.Content.ProductBvin.ToString();
                            string second = inv.Content.QuantityOnHand.ToString();
                            string csvRow = string.Format("{0};{1}", first, second);
                            stream.WriteLine(csvRow);
                        }

                        int progress = Convert.ToInt16((i + 1) * 100 / 178);
                        progressBar1.Value = progress;

                    }
                    kesz.Visible = true;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apiHivas();
            //itt kell majd egy osztályt példányosítani a datagridhez
            TablazatForm tablazatForm = new TablazatForm();
            tablazatForm.Show();
        }

        public Api apiHivas()
        {
            var url = string.Empty;
            var key = string.Empty;
            if (url == string.Empty) url = "http://20.234.113.211:8089";
            if (key == string.Empty) key = "1-0122fcb1-08c3-4c44-8b75-536a2245b3e5";
            var proxy = new Api(url, key);
            return proxy;

        }

        public string[] inventory = new string[] { "f1d45ca5-d3dc-409f-bea7-eb1357b3261d",
                            "eb531fea-5c02-43ac-bf09-14f02ff320be",
                            "e2dc9697-2135-4ca6-b833-b65a5510bddf",
                            "222ab345-ad72-4913-b45e-15b6f021b35d",
                            "f3052212-0e14-4f3b-a2b1-84ee3cab2029",
                            "372a74a2-f33b-43d2-8a56-a4d2a8bfbea2",
                            "1438df0c-9459-4ba3-b5e7-70a9a69b47a4",
                            "36580500-6f8e-4429-ba8e-48bb664df799",
                            "315a27c9-db6f-416d-9fba-26dd45cfd4e4",
                            "33002747-0983-4777-9a64-98dfd7c9c22b",
                            "7a35772c-89c0-46df-a4d8-27d85a120c9e",
                            "1916d092-2e7f-46c4-902d-4c0e18148e0e",
                            "715f5a42-1071-423c-82ef-b4d3c7a93062",
                            "db9a6700-0e95-42b5-a6d9-247952c32f3a",
                            "53952604-408a-4acc-b92d-548e52dc8182",
                            "7980e901-327b-4e06-9f15-9df8b420b888",
                            "90542265-7a73-40be-84d3-39e56a78ddcc",
                            "205cf32d-450a-4441-8d96-8bc5df60906b",
                            "fdbc13e4-1ecc-4081-9da5-18b3910cc0e3",
                            "ee71386e-cc8b-471e-92b7-6aeaa888da3b",
                            "dfde1bba-e9c1-4bc8-bb14-b45dcdda8a30",
                            "c47d61f9-0775-4ded-bd87-147e0db37854",
                            "120f476c-d734-4533-84be-eb5fa4c0adea",
                            "cf78ea73-a816-4f62-b3bc-b115374d35ea",
                            "29707560-7c91-4b79-b074-268c3b40073a",
                            "46264e70-2b35-4879-ac08-d960bba19da9",
                            "46f3422c-24a6-456b-88bb-9b4ffd2faa1c",
                            "60757858-8a06-4554-a7be-913668ddb288",
                            "e1115cf4-730d-4563-bce3-91d02c1e24e0",
                            "ef7c7e5b-1958-4d7d-bd8a-f093863de68f",
                            "d8a07eaa-cd48-409a-830d-5f33b6f3a0aa",
                            "75e6a902-522b-4575-a4a5-66d209fe5f6e",
                            "aa12d6ae-a072-466e-a7f6-91b9d5aecdeb",
                            "eca7bcc0-e9a1-41dd-b546-52b23a7ba092",
                            "83402bfe-772f-40e2-9026-d76046213c44",
                            "aa951ec5-6272-45f6-951f-b783589ed859",
                            "c1012529-b78a-49e7-a5d9-42a8af1a8864",
                            "7f400d9f-8462-4863-98d9-07c8cfbc178f",
                            "a8925701-70e0-487b-958d-ffd3d534cb59",
                            "569acbff-9579-446c-81ba-9ba5227829ee",
                            "8fc3fbe1-4ac4-4e88-8dc0-864e2cad1a37",
                            "905e70b8-1ad6-4b8e-972c-e830e66230bc",
                            "83949213-465b-4d04-90ac-b530f2e2dbb2",
                            "817d8679-c82f-4a20-86c7-aae932b423d9",
                            "0d4cc791-b734-4961-aa62-2f1182d7efd2",
                            "ad205d0d-db52-415c-bd54-22da21c63bde",
                            "61d626e7-b67e-4810-ba09-d95bcafb1f48",
                            "159c9dd2-eca9-4895-9f77-72b2592345c5",
                            "3384084f-56de-444c-af35-62fc245982f6",
                            "77c08c3d-b315-4d26-9511-5aee37bef9b0",
                            "fda3e6ae-75f3-4058-b725-01cac7d24dc0",
                            "52db7d48-6cf4-45ba-8e31-8f6946675c46",
                            "ea9e4c3a-4310-4a32-8c1d-498a38dcfa56",
                            "d2283dc2-fdf2-4af7-a1fe-40fc111c1953",
                            "2bf28ea8-22db-4453-881b-6007f7ea15cd",
                            "b3749526-da3d-4872-b182-3dc11d1205d9",
                            "a865722b-15c8-48c0-b5ed-45439ead8738",
                            "cb1eeffc-d91f-4728-84dc-42ac4b442ff1",
                            "e22e3738-0f47-4e28-bf8e-8d96ecdc967f",
                            "dd068def-302a-47ec-8b7c-8d2d705ad79b",
                            "2b750bf2-a748-4c5a-b081-a8cff7a351be",
                            "f8d7e1c5-68ff-4a30-a694-f6ad9c0488be",
                            "ebb2aad5-f85a-4080-8338-f74c32f8f1fa",
                            "eb450d5c-38fe-444d-bfcd-77c742b0619f",
                            "1118412c-150c-4008-a424-76e01170d05f",
                            "735441ef-1a6b-4559-b636-d1c9ad129386",
                            "77620599-ffdc-4af7-ae32-0a4452699a63",
                            "d28db2e7-b8b3-4840-90ae-8dac693f29c6",
                            "2d4ccbe0-d997-4ab5-af95-b6db63f70835",
                            "6af64a19-1d4a-4de4-800a-40a2b0859ae1",
                            "b0aad548-e3dc-4c02-871b-aded74a6340a",
                            "ec14927c-d3d5-413a-83ff-356104422533",
                            "ae755ace-404f-41ef-883c-c411d8edcc1a",
                            "43c231bb-3f63-4288-89d5-055248f8b6c5",
                            "fa0a3de5-7e01-423d-a1e0-bcd89ae30fa3",
                            "3092406f-2d8b-4f18-960e-7fd1e7c0c7d0",
                            "f2fe5af2-8202-4e0f-b50a-1119f15fd5a5",
                            "a5e288ca-ac73-4d63-af12-3343bfce0161",
                            "cf05df3d-b560-458e-b66e-a69ed8d5cfce",
                            "985a2cd7-a542-433c-9247-bade6186fe21",
                            "eee8137c-a744-4836-9e8a-fda2d630af9f",
                            "21db1415-fddc-412c-aede-c7f494bd0ae7",
                            "db105d18-4df5-4264-95d3-1cf3f9683c01",
                            "3cbf0718-b00a-4971-b98f-7cc0730e93cc",
                            "39bc1712-9771-4953-8efd-d14e1b99473c",
                            "5b14bbf6-1e41-46a5-8bc5-5bf8209d6561",
                            "2f23adcd-b31e-4416-b6c2-7b36b48d4e4d",
                            "6a626442-03fa-42a4-b75d-db22a0ce523a",
                            "534893f0-3976-4054-82a6-b5438a93dc74",
                            "0e7bfa8b-dd18-4391-ba81-238aa20bad69",
                            "d3f7ab0e-ffb5-41b7-95a1-b3eca88e7ff0",
                            "bcc9037e-5917-4af1-8400-acddc4e200d5",
                            "04891f8c-f33b-493a-a4bf-338e4eb5de11",
                            "a08536e9-18c6-48fe-9495-a249fbfc8c1f",
                            "75ff64c7-72f4-405c-8218-a65aa4af6086",
                            "814b8cab-de7a-4153-b78e-58cf2ba6a7e0",
                            "91e1c19e-8f99-447a-8d61-dd08b4c1d040",
                            "3c111892-de4e-42ad-8952-09701556aab1",
                            "390b00a8-4921-4383-86b5-36a60d585885",
                            "caea4dd2-17af-4bc4-8a4f-327117a39c0b",
                            "d4607d45-9806-4e47-815f-dfdc668215df",
                            "8eb25706-91d1-418f-87e3-dd894cc55377",
                            "fc3b6013-bfaf-45e5-8aca-5d465e5dff9f",
                            "352d280d-a5b1-43f1-8102-52d694a48bcd",
                            "f914bc40-9891-41ba-8fef-f9d7815c8f93",
                            "d3b620ee-030d-4bab-81e1-4bb70b2c763d",
                            "5733ef41-9945-4f3d-bb65-468d0b7bd4cc",
                            "865d9931-4a2f-41bc-ab01-4e46640474f2",
                            "d5f5a68b-09f6-42ab-8562-f8f7f1b37b5d",
                            "9dbcd097-ed5c-471f-9595-5fc97deb377e",
                            "75654c84-950c-4cda-bef4-e027cd81802c",
                            "eb8a5f66-1e37-426a-ad4d-0ebcd8e1560c",
                            "ec6104c6-385e-4821-a0f5-997f39f8f7e7",
                            "7b9cca5c-4058-4c1a-a0c6-6faed011ec66",
                            "23fec188-379d-40a5-9409-d4db8884006f",
                            "41200f78-59d6-4af6-ae7c-daa856d5f1c5",
                            "123de242-676a-433b-bd67-006bb82afaca",
                            "99cc11f6-ed7f-444d-81d0-9c163a778759",
                            "9778b5f9-27da-4a67-a747-9ae6a6b452b6",
                            "75cc87f5-1d6a-47b1-b328-5869a402e009",
                            "dcd58569-4146-40da-b15f-5100cf822ea5",
                            "b8e54e06-0ec5-4654-9201-365cb4fe7e38",
                            "2c204d5d-f7c3-4071-83cc-f7f6c860361d",
                            "a05d2545-72ed-4b2a-8cd1-7ae8782cb2e1",
                            "9edb91df-9aa3-4202-a24b-129a16330928",
                            "4c0e66fc-9756-4725-94c7-c36ef46d0571",
                            "62d8fd90-7e60-4b73-bde3-5b49dfe535eb",
                            "ca7369ae-b07f-4931-81b8-fdabfa618acf",
                            "d8caf6bf-e6e4-4e57-8caf-9f81793c9db2",
                            "8b217408-943b-4ff5-a56b-3edc88d16e75",
                            "857c312a-9777-4971-bdf8-ced8ad9c6320",
                            "87d36128-3a31-4cdc-9436-83d6c5f36024",
                            "f4a9a6a6-d1df-41de-b177-91b3f745f1de",
                            "b5a2cd17-982b-458a-9c8c-d4fdc92ed423",
                            "0d32cb3a-2895-481a-b9b3-690479f5f139",
                            "3d7d3417-2fff-44f9-9ffa-dcbfb87b2ef0",
                            "0508b7f7-2278-4869-a142-f2376fde04c3",
                            "9ed068ad-a7c3-43b2-855e-2cbc3846d06a",
                            "f8000ac3-6da5-408a-8a93-6f90c690f37e",
                            "7e8af906-6c4d-4378-89c9-ea918cc0ca5e",
                            "95b3e4c5-4815-437e-bc51-05e97503b52b",
                            "11a09715-1ee1-46ce-9eb8-d9f5100c645b",
                            "4561a6f0-f180-495e-ac4d-e840d8f06f26",
                            "c7539a2b-4e77-42df-ab14-7af932ed6da1",
                            "fac6a56e-ce9a-4b6b-bf6c-8aec7194fcc3",
                            "1d96e433-a4b4-42da-a5b5-13b6daee5b67",
                            "b04c06b2-23c2-4c87-b270-23cfe0a0b578",
                            "49234498-2c9d-466c-8717-7b237d1ecada",
                            "d51598dc-7203-4268-89b1-aabf07e3a0ec",
                            "e0ad5876-29e9-4c1c-84cf-e287828004cf",
                            "d01582b7-6a62-4ad6-a300-f4bce0345e6a",
                            "77e856ac-6a4b-4bee-8570-b6e63b2afdd8",
                            "2e0689b2-bb82-46ff-abe2-7cd533e68120",
                            "c7b023d1-ef18-4932-bac6-0d910b2da890",
                            "68c99bfd-4c34-481d-854a-4b1028441c45",
                            "4dde2801-4ac9-4394-98ee-be1f8a9a65a6",
                            "2ad7a4b6-b33b-43cc-814d-d0ed2a904306",
                            "27a839d6-7b3b-4419-ac02-453808de3187",
                            "2a1aebc9-7258-4d8d-9a28-74c980c83dde",
                            "e2018325-9679-45bc-abb2-69bc146e3595",
                            "f544ab52-d543-424d-9b66-519dd2a10174",
                            "cd4070ce-0354-4806-b9f7-5a7dbfcdc7b4",
                            "ca5cfbfa-8a59-4d64-a134-1d8b9fc166d7",
                            "59d30019-d273-470b-9e93-6ed71df7e524",
                            "73b2740b-ff5a-4846-80cb-b37e8f5bd102",
                            "a449c794-b0e5-4f27-86fb-c3394931adcf",
                            "7a909237-9940-4e76-a9fd-9eaab92e26fa",
                            "30bd5564-4c29-4f9c-9f1a-c64024977a59",
                            "1af55baf-999c-4797-a5a9-9ecba837a243",
                            "3b229d87-7405-4b58-87c6-61d506557a00",
                            "db56a460-9565-46c8-90d7-964d2b18da55",
                            "863fbd96-323e-4d04-ad8b-d1871ef236ae",
                            "00d2c90a-1b63-4aca-b185-8fcc30d2db3b",
                            "7804a272-f777-4345-bc0c-8ad70b80b0f1",
                            "00bf974e-a645-42c9-b01f-1abbe5ad72bb",
                            "28ad0070-a3a9-4f4f-ba75-335cb143e25b",
                            "8544364d-bc28-4620-b66b-e5b1d327de87",
                            "d8795d6d-6ccb-4e2a-ac54-4172897e5d24",
                            "3da60b6a-69be-4770-9b5e-6ae42a16d6b7"
        };
    }
}

