using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIntoExcel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Root
    {
        [Newtonsoft.Json.JsonProperty("respondentName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RespondentName { get; set; }

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("respondent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Respondent { get; set; }

        [Newtonsoft.Json.JsonProperty("member", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Member { get; set; }

        [Newtonsoft.Json.JsonProperty("2_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_2 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_3 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_4 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_5", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_5 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_6", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_6 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_7_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_7_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_7_2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_7_2 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_7_3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_7_3 { get; set; }

        [Newtonsoft.Json.JsonProperty("2_7_4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _2_7_4 { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1 { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1a_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1a_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1a_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1a_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1b_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1b_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1b_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1b_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1b_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1b_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1c_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1c_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1c_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1c_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1c_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1c_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1d_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1d_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1d_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1d_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1d_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1d_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1e", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1e { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1f", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1f { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_1_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_1_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2a", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2a { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2b", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2b { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2c", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2c { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2d { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2f", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2f { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2g", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2g { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2h", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2h { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2i", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2i { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_2j", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_2j { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3a", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3a { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3b", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3b { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3c", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3c { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3d { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3e", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3e { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3f", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3f { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3g", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3g { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3h", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3h { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3i", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3i { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3j", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3j { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3k", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3k { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3l", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3l { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3m", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3m { get; set; }

        [Newtonsoft.Json.JsonProperty("3A1_3_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A1_3_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1a_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1a_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1a_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1a_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1a_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1a_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1b", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1b { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1c_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1c_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1c_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1c_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1c_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1c_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1d { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1e_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1e_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1e_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1e_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1e_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1e_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1f_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1f_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1f_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1f_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_1f_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_1f_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2a_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2a_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2a_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2a_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2a_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2a_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2b_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2b_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2b_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2b_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2b_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2b_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2c_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2c_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2c_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2c_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2c_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2c_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2d_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2d_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2d_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2d_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2d_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2d_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_2_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_2_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_3a", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_3a { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_3b", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_3b { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_3c", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_3c { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_3d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_3d { get; set; }

        [Newtonsoft.Json.JsonProperty("3A2_3_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A2_3_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_1a", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_1a { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_1b", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_1b { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_1c", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_1c { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_1d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_1d { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_1e", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_1e { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_1_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_1_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_2a", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_2a { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_2b", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_2b { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_2c", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_2c { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_2d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_2d { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_2e", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_2e { get; set; }

        [Newtonsoft.Json.JsonProperty("3A3_2_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3A3_2_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_1PP", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_1PP { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_1FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_1FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_1SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_1SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_1TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_1TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2a_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2a_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2a_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2a_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2a_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2a_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2b_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2b_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2b_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2b_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2b_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2b_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2c_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2c_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2c_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2c_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2c_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2c_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2d_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2d_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2d_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2d_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2d_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2d_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2e_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2e_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2e_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2e_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2e_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2e_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2f_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2f_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2f_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2f_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2f_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2f_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_3_PP", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_3_PP { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_3_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_3_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("3B1_3_ATOAMC", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B1_3_ATOAMC { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2a_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2a_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2a_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2a_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2a_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2a_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2b_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2b_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2b_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2b_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2b_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2b_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3B2_2_ATOAMC", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3B2_2_ATOAMC { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_5_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_5_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_5_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_5_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_5_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_5_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_5_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_5_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_6_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_6_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_6_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_6_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_6_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_6_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_6_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_6_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_7_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_7_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_7_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_7_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_7_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_7_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_7_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_7_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_8_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_8_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_8_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_8_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_8_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_8_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_8_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_8_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_9_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_9_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_9_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_9_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_9_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_9_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_9_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_9_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_10_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_10_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_10_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_10_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_10_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_10_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_1_10_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_1_10_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_5_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_5_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_5_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_5_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_5_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_5_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_5_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_5_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_6_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_6_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_6_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_6_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_6_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_6_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_6_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_6_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_7_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_7_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_7_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_7_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_7_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_7_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_7_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_7_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_8_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_8_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_8_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_8_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_8_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_8_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_2_8_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_2_8_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_3_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_3_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_5_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_5_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_5_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_5_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_5_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_5_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_5_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_5_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_6_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_6_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_6_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_6_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_6_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_6_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_6_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_6_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_7_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_7_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_7_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_7_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_7_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_7_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_4_7_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_4_7_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_5_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_5_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_5_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_5_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_5_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_5_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_5_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_5_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_5_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_5_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_5_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_5_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_5_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_5_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_5_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_5_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_6_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_6_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_6_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_6_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_6_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_6_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_6_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_6_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_7_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_7_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_7_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_7_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_7_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_7_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_2_7_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_2_7_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_1_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_1_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_2_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_2_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_3_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_3_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_4_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_4_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_4_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_4_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_4_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_4_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_4_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_4_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_5_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_5_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_5_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_5_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_5_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_5_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_5_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_5_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_6_PR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_6_PR { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_6_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_6_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_6_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_6_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("3C_5_3_6_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3C_5_3_6_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("3D_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3D_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("3D_2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3D_2 { get; set; }

        [Newtonsoft.Json.JsonProperty("3D_3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3D_3 { get; set; }

        [Newtonsoft.Json.JsonProperty("3D_4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3D_4 { get; set; }

        [Newtonsoft.Json.JsonProperty("3D_5", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3D_5 { get; set; }

        [Newtonsoft.Json.JsonProperty("3D_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _3D_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_2 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_3 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_4 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_5", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_5 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_6", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_6 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_7", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_7 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_8", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_8 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_9", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_9 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_1_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_1_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_2_1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_2_1 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_2_2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_2_2 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_2_3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_2_3 { get; set; }

        [Newtonsoft.Json.JsonProperty("4D_2_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _4D_2_AOINFO { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_1_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_1_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_1_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_1_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_1_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_1_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_2_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_2_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_2_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_2_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_2_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_2_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_3_FW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_3_FW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_3_SW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_3_SW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_3_TW", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_3_TW { get; set; }

        [Newtonsoft.Json.JsonProperty("5E_3_AOINFO", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _5E_3_AOINFO { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
        //public string respondentName { get; set; }
        //public int? id { get; set; }
        //public string name { get; set; }
        //public string respondent { get; set; }
        //public string member { get; set; }
        //public string _2_1 { get; set; }
        //public string _2_2 { get; set; }
        //public string _2_3 { get; set; }
        //public string _2_4 { get; set; }
        //public string _2_5 { get; set; }
        //public string _2_6 { get; set; }
        //public string _2_7_1 { get; set; }
        //public string _2_7_2 { get; set; }
        //public string _2_7_3 { get; set; }
        //public string _2_7_4 { get; set; }
        //public string _3A1 { get; set; }
        //public string _3A1_1 { get; set; }
        //public string _3A1_1a_SW { get; set; }
        //public string _3A1_1a_TW { get; set; }
        //public string _3A1_1b_FW { get; set; }
        //public string _3A1_1b_SW { get; set; }
        //public string _3A1_1b_TW { get; set; }
        //public string _3A1_1c_FW { get; set; }
        //public string _3A1_1c_SW { get; set; }
        //public string _3A1_1c_TW { get; set; }
        //public string _3A1_1d_FW { get; set; }
        //public string _3A1_1d_SW { get; set; }
        //public string _3A1_1d_TW { get; set; }
        //public string _3A1_1e { get; set; }
        //public string _3A1_1f { get; set; }
        //public string _3A1_1_AOINFO { get; set; }
        //public string _3A1_2a { get; set; }
        //public string _3A1_2b { get; set; }
        //public string _3A1_2c { get; set; }
        //public string _3A1_2d { get; set; }
        //public string _3A1_2f { get; set; }
        //public string _3A1_2g { get; set; }
        //public string _3A1_2h { get; set; }
        //public string _3A1_2i { get; set; }
        //public string _3A1_2j { get; set; }
        //public string _3A1_3a { get; set; }
        //public string _3A1_3b { get; set; }
        //public string _3A1_3c { get; set; }
        //public string _3A1_3d { get; set; }
        //public string _3A1_3e { get; set; }
        //public string _3A1_3f { get; set; }
        //public string _3A1_3g { get; set; }
        //public string _3A1_3h { get; set; }
        //public string _3A1_3i { get; set; }
        //public string _3A1_3j { get; set; }
        //public string _3A1_3k { get; set; }
        //public string _3A1_3l { get; set; }
        //public string _3A1_3m { get; set; }
        //public string _3A1_3_AOINFO { get; set; }
        //public string _3A2_1a_FW { get; set; }
        //public string _3A2_1a_SW { get; set; }
        //public string _3A2_1a_TW { get; set; }
        //public string _3A2_1b { get; set; }
        //public string _3A2_1c_FW { get; set; }
        //public string _3A2_1c_SW { get; set; }
        //public string _3A2_1c_TW { get; set; }
        //public string _3A2_1d { get; set; }
        //public string _3A2_1e_FW { get; set; }
        //public string _3A2_1e_SW { get; set; }
        //public string _3A2_1e_TW { get; set; }
        //public string _3A2_1f_FW { get; set; }
        //public string _3A2_1f_SW { get; set; }
        //public string _3A2_1f_TW { get; set; }
        //public string _3A2_2a_FW { get; set; }
        //public string _3A2_2a_SW { get; set; }
        //public string _3A2_2a_TW { get; set; }
        //public string _3A2_2b_FW { get; set; }
        //public string _3A2_2b_SW { get; set; }
        //public string _3A2_2b_TW { get; set; }
        //public string _3A2_2c_FW { get; set; }
        //public string _3A2_2c_SW { get; set; }
        //public string _3A2_2c_TW { get; set; }
        //public string _3A2_2d_FW { get; set; }
        //public string _3A2_2d_SW { get; set; }
        //public string _3A2_2d_TW { get; set; }
        //public string _3A2_2_AOINFO { get; set; }
        //public string _3A2_3a { get; set; }
        //public string _3A2_3b { get; set; }
        //public string _3A2_3c { get; set; }
        //public string _3A2_3d { get; set; }
        //public string _3A2_3_AOINFO { get; set; }
        //public string _3A3_1a { get; set; }
        //public string _3A3_1b { get; set; }
        //public string _3A3_1c { get; set; }
        //public string _3A3_1d { get; set; }
        //public string _3A3_1e { get; set; }
        //public string _3A3_1_AOINFO { get; set; }
        //public string _3A3_2a { get; set; }
        //public string _3A3_2b { get; set; }
        //public string _3A3_2c { get; set; }
        //public string _3A3_2d { get; set; }
        //public string _3A3_2e { get; set; }
        //public string _3A3_2_AOINFO { get; set; }
        //public string _3B1_1PP { get; set; }
        //public string _3B1_1FW { get; set; }
        //public string _3B1_1SW { get; set; }
        //public string _3B1_1TW { get; set; }
        //public string _3B2a_FW { get; set; }
        //public string _3B2a_SW { get; set; }
        //public string _3B2a_TW { get; set; }
        //public string _3B2b_FW { get; set; }
        //public string _3B2b_SW { get; set; }
        //public string _3B2b_TW { get; set; }
        //public string _3B2c_FW { get; set; }
        //public string _3B2c_SW { get; set; }
        //public string _3B2c_TW { get; set; }
        //public string _3B2d_FW { get; set; }
        //public string _3B2d_SW { get; set; }
        //public string _3B2d_TW { get; set; }
        //public string _3B2e_FW { get; set; }
        //public string _3B2e_SW { get; set; }
        //public string _3B2e_TW { get; set; }
        //public string _3B2f_FW { get; set; }
        //public string _3B2f_SW { get; set; }
        //public string _3B2f_TW { get; set; }
        //public string _3B1_3_PP { get; set; }
        //public string _3B1_3_FW { get; set; }
        //public string _3B1_3_SW { get; set; }
        //public string _3B1_3_TW { get; set; }
        //public string _3B1_3_AOINFO { get; set; }
        //public string _3B1_3_ATOAMC { get; set; }
        //public string _3B2_1_FW { get; set; }
        //public string _3B2_1_SW { get; set; }
        //public string _3B2_1_TW { get; set; }
        //public string _3B2_2a_FW { get; set; }
        //public string _3B2_2a_SW { get; set; }
        //public string _3B2_2a_TW { get; set; }
        //public string _3B2_2b_FW { get; set; }
        //public string _3B2_2b_SW { get; set; }
        //public string _3B2_2b_TW { get; set; }
        //public string _3B2_2_ATOAMC { get; set; }
        //public string _3C_1_1_PR { get; set; }
        //public string _3C_1_1_FW { get; set; }
        //public string _3C_1_1_SW { get; set; }
        //public string _3C_1_1_TW { get; set; }
        //public string _3C_1_2_PR { get; set; }
        //public string _3C_1_2_FW { get; set; }
        //public string _3C_1_2_SW { get; set; }
        //public string _3C_1_2_TW { get; set; }
        //public string _3C_1_3_PR { get; set; }
        //public string _3C_1_3_FW { get; set; }
        //public string _3C_1_3_SW { get; set; }
        //public string _3C_1_3_TW { get; set; }
        //public string _3C_1_4_PR { get; set; }
        //public string _3C_1_4_FW { get; set; }
        //public string _3C_1_4_SW { get; set; }
        //public string _3C_1_4_TW { get; set; }
        //public string _3C_1_5_PR { get; set; }
        //public string _3C_1_5_FW { get; set; }
        //public string _3C_1_5_SW { get; set; }
        //public string _3C_1_5_TW { get; set; }
        //public string _3C_1_6_PR { get; set; }
        //public string _3C_1_6_FW { get; set; }
        //public string _3C_1_6_SW { get; set; }
        //public string _3C_1_6_TW { get; set; }
        //public string _3C_1_7_PR { get; set; }
        //public string _3C_1_7_FW { get; set; }
        //public string _3C_1_7_SW { get; set; }
        //public string _3C_1_7_TW { get; set; }
        //public string _3C_1_8_PR { get; set; }
        //public string _3C_1_8_FW { get; set; }
        //public string _3C_1_8_SW { get; set; }
        //public string _3C_1_8_TW { get; set; }
        //public string _3C_1_9_PR { get; set; }
        //public string _3C_1_9_FW { get; set; }
        //public string _3C_1_9_SW { get; set; }
        //public string _3C_1_9_TW { get; set; }
        //public string _3C_1_10_PR { get; set; }
        //public string _3C_1_10_FW { get; set; }
        //public string _3C_1_10_SW { get; set; }
        //public string _3C_1_10_TW { get; set; }
        //public string _3C_2_1_PR { get; set; }
        //public string _3C_2_1_FW { get; set; }
        //public string _3C_2_1_SW { get; set; }
        //public string _3C_2_1_TW { get; set; }
        //public string _3C_2_2_PR { get; set; }
        //public string _3C_2_2_FW { get; set; }
        //public string _3C_2_2_SW { get; set; }
        //public string _3C_2_2_TW { get; set; }
        //public string _3C_2_3_PR { get; set; }
        //public string _3C_2_3_FW { get; set; }
        //public string _3C_2_3_SW { get; set; }
        //public string _3C_2_3_TW { get; set; }
        //public string _3C_2_4_PR { get; set; }
        //public string _3C_2_4_FW { get; set; }
        //public string _3C_2_4_SW { get; set; }
        //public string _3C_2_4_TW { get; set; }
        //public string _3C_2_5_PR { get; set; }
        //public string _3C_2_5_FW { get; set; }
        //public string _3C_2_5_SW { get; set; }
        //public string _3C_2_5_TW { get; set; }
        //public string _3C_2_6_PR { get; set; }
        //public string _3C_2_6_FW { get; set; }
        //public string _3C_2_6_SW { get; set; }
        //public string _3C_2_6_TW { get; set; }
        //public string _3C_2_7_PR { get; set; }
        //public string _3C_2_7_FW { get; set; }
        //public string _3C_2_7_SW { get; set; }
        //public string _3C_2_7_TW { get; set; }
        //public string _3C_2_8_PR { get; set; }
        //public string _3C_2_8_FW { get; set; }
        //public string _3C_2_8_SW { get; set; }
        //public string _3C_2_8_TW { get; set; }
        //public string _3C_3_1_PR { get; set; }
        //public string _3C_3_1_FW { get; set; }
        //public string _3C_3_1_SW { get; set; }
        //public string _3C_3_1_TW { get; set; }
        //public string _3C_3_2_PR { get; set; }
        //public string _3C_3_2_FW { get; set; }
        //public string _3C_3_2_SW { get; set; }
        //public string _3C_3_2_TW { get; set; }
        //public string _3C_3_3_PR { get; set; }
        //public string _3C_3_3_FW { get; set; }
        //public string _3C_3_3_SW { get; set; }
        //public string _3C_3_3_TW { get; set; }
        //public string _3C_3_4_PR { get; set; }
        //public string _3C_3_4_FW { get; set; }
        //public string _3C_3_4_SW { get; set; }
        //public string _3C_3_4_TW { get; set; }
        //public string _3C_4_1_PR { get; set; }
        //public string _3C_4_1_FW { get; set; }
        //public string _3C_4_1_SW { get; set; }
        //public string _3C_4_1_TW { get; set; }
        //public string _3C_4_2_PR { get; set; }
        //public string _3C_4_2_FW { get; set; }
        //public string _3C_4_2_SW { get; set; }
        //public string _3C_4_2_TW { get; set; }
        //public string _3C_4_3_PR { get; set; }
        //public string _3C_4_3_FW { get; set; }
        //public string _3C_4_3_SW { get; set; }
        //public string _3C_4_3_TW { get; set; }
        //public string _3C_4_4_PR { get; set; }
        //public string _3C_4_4_FW { get; set; }
        //public string _3C_4_4_SW { get; set; }
        //public string _3C_4_4_TW { get; set; }
        //public string _3C_4_5_PR { get; set; }
        //public string _3C_4_5_FW { get; set; }
        //public string _3C_4_5_SW { get; set; }
        //public string _3C_4_5_TW { get; set; }
        //public string _3C_4_6_PR { get; set; }
        //public string _3C_4_6_FW { get; set; }
        //public string _3C_4_6_SW { get; set; }
        //public string _3C_4_6_TW { get; set; }
        //public string _3C_4_7_PR { get; set; }
        //public string _3C_4_7_FW { get; set; }
        //public string _3C_4_7_SW { get; set; }
        //public string _3C_4_7_TW { get; set; }
        //public string _3C_5_1_PR { get; set; }
        //public string _3C_5_1_FW { get; set; }
        //public string _3C_5_1_SW { get; set; }
        //public string _3C_5_1_TW { get; set; }
        //public string _3C_5_2_PR { get; set; }
        //public string _3C_5_2_FW { get; set; }
        //public string _3C_5_2_SW { get; set; }
        //public string _3C_5_2_TW { get; set; }
        //public string _3C_5_3_PR { get; set; }
        //public string _3C_5_3_FW { get; set; }
        //public string _3C_5_3_SW { get; set; }
        //public string _3C_5_3_TW { get; set; }
        //public string _3C_5_4_PR { get; set; }
        //public string _3C_5_4_FW { get; set; }
        //public string _3C_5_4_SW { get; set; }
        //public string _3C_5_4_TW { get; set; }
        //public string _3C_5_5_PR { get; set; }
        //public string _3C_5_5_FW { get; set; }
        //public string _3C_5_5_SW { get; set; }
        //public string _3C_5_5_TW { get; set; }
        //public string _3C_5_2_1_PR { get; set; }
        //public string _3C_5_2_1_FW { get; set; }
        //public string _3C_5_2_1_SW { get; set; }
        //public string _3C_5_2_1_TW { get; set; }
        //public string _3C_5_2_2_PR { get; set; }
        //public string _3C_5_2_2_FW { get; set; }
        //public string _3C_5_2_2_SW { get; set; }
        //public string _3C_5_2_2_TW { get; set; }
        //public string _3C_5_2_3_PR { get; set; }
        //public string _3C_5_2_3_FW { get; set; }
        //public string _3C_5_2_3_SW { get; set; }
        //public string _3C_5_2_3_TW { get; set; }
        //public string _3C_5_2_4_PR { get; set; }
        //public string _3C_5_2_4_FW { get; set; }
        //public string _3C_5_2_4_SW { get; set; }
        //public string _3C_5_2_4_TW { get; set; }
        //public string _3C_5_2_5_PR { get; set; }
        //public string _3C_5_2_5_FW { get; set; }
        //public string _3C_5_2_5_SW { get; set; }
        //public string _3C_5_2_5_TW { get; set; }
        //public string _3C_5_2_6_PR { get; set; }
        //public string _3C_5_2_6_FW { get; set; }
        //public string _3C_5_2_6_SW { get; set; }
        //public string _3C_5_2_6_TW { get; set; }
        //public string _3C_5_3_1_PR { get; set; }
        //public string _3C_5_3_1_FW { get; set; }
        //public string _3C_5_3_1_SW { get; set; }
        //public string _3C_5_3_1_TW { get; set; }
        //public string _3C_5_3_2_PR { get; set; }
        //public string _3C_5_3_2_FW { get; set; }
        //public string _3C_5_3_2_SW { get; set; }
        //public string _3C_5_3_2_TW { get; set; }
        //public string _3C_5_3_3_PR { get; set; }
        //public string _3C_5_3_3_FW { get; set; }
        //public string _3C_5_3_3_SW { get; set; }
        //public string _3C_5_3_3_TW { get; set; }
        //public string _3C_5_3_4_PR { get; set; }
        //public string _3C_5_3_4_FW { get; set; }
        //public string _3C_5_3_4_SW { get; set; }
        //public string _3C_5_3_4_TW { get; set; }
        //public string _3C_5_3_5_PR { get; set; }
        //public string _3C_5_3_5_FW { get; set; }
        //public string _3C_5_3_5_SW { get; set; }
        //public string _3C_5_3_5_TW { get; set; }
        //public string _3C_5_3_6_PR { get; set; }
        //public string _3C_5_3_6_FW { get; set; }
        //public string _3C_5_3_6_SW { get; set; }
        //public string _3C_5_3_6_TW { get; set; }
        //public string _3D_1 { get; set; }
        //public string _3D_2 { get; set; }
        //public string _3D_3 { get; set; }
        //public string _3D_4 { get; set; }
        //public string _3D_5 { get; set; }
        //public string _3D_AOINFO { get; set; }
        //public string _4D_1_1 { get; set; }
        //public string _4D_1_2 { get; set; }
        //public string _4D_1_3 { get; set; }
        //public string _4D_1_4 { get; set; }
        //public string _4D_1_5 { get; set; }
        //public string _4D_1_6 { get; set; }
        //public string _4D_1_7 { get; set; }
        //public string _4D_1_8 { get; set; }
        //public string _4D_1_9 { get; set; }
        //public string _4D_1_AOINFO { get; set; }
        //public string _4D_2_1 { get; set; }
        //public string _4D_2_2 { get; set; }
        //public string _4D_2_3 { get; set; }
        //public string _4D_2_AOINFO { get; set; }
        //public string _5E_1_FW { get; set; }
        //public string _5E_1_SW { get; set; }
        //public string _5E_1_TW { get; set; }
        //public string _5E_2_FW { get; set; }
        //public string _5E_2_SW { get; set; }
        //public string _5E_2_TW { get; set; }
        //public string _5E_3_FW { get; set; }
        //public string _5E_3_SW { get; set; }
        //public string _5E_3_TW { get; set; }
        //public string _5E_3_AOINFO { get; set; }
    }

}
