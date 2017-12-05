using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WordPressPCL.Models
{

    public class Photo
    {
        public string ID { get; set; }
        public string post_author { get; set; }
        public string post_date { get; set; }
        public string post_date_gmt { get; set; }
        public string post_content { get; set; }
        public string post_title { get; set; }
        public string post_excerpt { get; set; }
        public string post_status { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public string post_password { get; set; }
        public string post_name { get; set; }
        public string to_ping { get; set; }
        public string pinged { get; set; }
        public string post_modified { get; set; }
        public string post_modified_gmt { get; set; }
        public string post_content_filtered { get; set; }
        public string post_parent { get; set; }
        public string guid { get; set; }
        public string menu_order { get; set; }
        public string post_type { get; set; }
        public string post_mime_type { get; set; }
        public string comment_count { get; set; }
        public string pod_item_id { get; set; }
    }

  public class Resident : INotifyPropertyChanged
{
    public int id { get; set; }
    public DateTime date { get; set; }
    public DateTime date_gmt { get; set; }
    public Guid guid { get; set; }
    public DateTime modified { get; set; }
    public DateTime modified_gmt { get; set; }
    public string slug { get; set; }
    public string status { get; set; }
    public string type { get; set; }
    public string link { get; set; }
    public int menu_order { get; set; }
    public string template { get; set; }
    public string format { get; set; }
    public Photo photo { get; set; }
    public string combined_name { get; set; }
    public string address { get; set; }
    public string primary_phone { get; set; }
    public string alternate_phone { get; set; }
    public string primary_email { get; set; }
    public string alternate_email { get; set; }
    public string moved_from { get; set; }
    public string move_in_date { get; set; }
    public string person_1_name { get; set; }
    public string person_2_name { get; set; }
    public string person_1_birthday { get; set; }
    public string person_2_birthday { get; set; }
    public string unlisted { get; set; }
    public string resident { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
}
}
