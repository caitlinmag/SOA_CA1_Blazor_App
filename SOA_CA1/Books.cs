namespace SOA_CA1
{
    public class Books : IComparable<Books>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Books(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

   public override bool Equals(object? obj)
        {
            if (!(obj is Books))
            {
                return false;
            }

            var book = (Books)obj;
            if (book.Title.Equals(Title))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Books left, Books right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Books left, Books right)
        {
            return !left.Equals(right);
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public int CompareTo(Books? other)
        {
            int result = string.Compare(Title, other.Title);
            if(result == 0)
            {
                result = this.Year.CompareTo(other.Year);
            }
            return result;
        }
    }

    public class Rootobject
    {
        public int numFound { get; set; }
        public int start { get; set; }
        public bool numFoundExact { get; set; }
        public int num_found { get; set; }
        public string documentation_url { get; set; }
        public string q { get; set; }
        public object offset { get; set; }
        public Doc[] docs { get; set; }
    }

    public class Doc
    {
        public string[] author_alternative_name { get; set; }
        public string[] author_key { get; set; }
        public string[] author_name { get; set; }
        public string cover_edition_key { get; set; }
        public int cover_i { get; set; }
        public string ebook_access { get; set; }
        public int ebook_count_i { get; set; }
        public string[] ebook_provider { get; set; }
        public int edition_count { get; set; }
        public string[] edition_key { get; set; }
        public int first_publish_year { get; set; }
        public string[] format { get; set; }
        public bool has_fulltext { get; set; }
        public string[] ia { get; set; }
        public string[] ia_collection { get; set; }
        public string ia_collection_s { get; set; }
        public string[] isbn { get; set; }
        public string key { get; set; }
        public int last_modified_i { get; set; }
        public string lending_edition_s { get; set; }
        public string lending_identifier_s { get; set; }
        public int number_of_pages_median { get; set; }
        public string[] oclc { get; set; }
        public string printdisabled_s { get; set; }
        public bool public_scan_b { get; set; }
        public string[] publish_date { get; set; }
        public int[] publish_year { get; set; }
        public string[] publisher { get; set; }
        public string[] seed { get; set; }
        public string title { get; set; }
        public string title_suggest { get; set; }
        public string title_sort { get; set; }
        public string type { get; set; }
        public string[] id_goodreads { get; set; }
        public string[] id_librarything { get; set; }
        public int ratings_count_1 { get; set; }
        public int ratings_count_2 { get; set; }
        public int ratings_count_3 { get; set; }
        public int ratings_count_4 { get; set; }
        public int ratings_count_5 { get; set; }
        public float ratings_average { get; set; }
        public float ratings_sortable { get; set; }
        public int ratings_count { get; set; }
        public int readinglog_count { get; set; }
        public int want_to_read_count { get; set; }
        public int currently_reading_count { get; set; }
        public int already_read_count { get; set; }
        public int trending_score_hourly_11 { get; set; }
        public int trending_score_hourly_10 { get; set; }
        public int trending_score_hourly_13 { get; set; }
        public int trending_score_hourly_12 { get; set; }
        public int trending_score_hourly_15 { get; set; }
        public int trending_score_hourly_14 { get; set; }
        public int trending_score_hourly_17 { get; set; }
        public int trending_score_hourly_16 { get; set; }
        public int trending_score_hourly_18 { get; set; }
        public int trending_score_daily_5 { get; set; }
        public int trending_score_daily_6 { get; set; }
        public int trending_score_daily_1 { get; set; }
        public int trending_score_daily_2 { get; set; }
        public int trending_score_daily_3 { get; set; }
        public int trending_score_daily_4 { get; set; }
        public int trending_score_daily_0 { get; set; }
        public int trending_score_hourly_20 { get; set; }
        public string[] publisher_facet { get; set; }
        public int trending_score_hourly_22 { get; set; }
        public int trending_score_hourly_21 { get; set; }
        public int trending_score_hourly_0 { get; set; }
        public int trending_score_hourly_23 { get; set; }
        public int trending_score_hourly_1 { get; set; }
        public int trending_score_hourly_2 { get; set; }
        public int trending_score_hourly_3 { get; set; }
        public int trending_score_hourly_4 { get; set; }
        public int trending_score_hourly_5 { get; set; }
        public int trending_score_hourly_6 { get; set; }
        public int trending_score_hourly_7 { get; set; }
        public int trending_score_hourly_8 { get; set; }
        public long _version_ { get; set; }
        public float trending_z_score { get; set; }
        public string[] author_facet { get; set; }
        public int trending_score_hourly_sum { get; set; }
        public Availability availability { get; set; }
    }

    public class Availability
    {
        public string status { get; set; }
        public bool available_to_browse { get; set; }
        public bool available_to_borrow { get; set; }
        public bool available_to_waitlist { get; set; }
        public bool is_printdisabled { get; set; }
        public bool is_readable { get; set; }
        public bool is_lendable { get; set; }
        public bool is_previewable { get; set; }
        public string identifier { get; set; }
        public string isbn { get; set; }
        public object oclc { get; set; }
        public string openlibrary_work { get; set; }
        public string openlibrary_edition { get; set; }
        public object last_loan_date { get; set; }
        public object num_waitlist { get; set; }
        public object last_waitlist_date { get; set; }
        public bool is_restricted { get; set; }
        public bool is_browseable { get; set; }
        public string __src__ { get; set; }
    }
}

