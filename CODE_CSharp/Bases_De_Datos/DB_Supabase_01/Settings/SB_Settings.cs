using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Supabase_01.Settings
{
    class SB_Settings
    {
        private readonly string url;
        private readonly string key;
        private readonly Supabase.Client supabase;

        public SB_Settings ()
        {
            url = Environment.GetEnvironmentVariable( "https://jjthoqlzqsfmyypfhpyd.supabase.co" );
            key = Environment.GetEnvironmentVariable( "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImpqdGhvcWx6cXNmbXl5cGZocHlkIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTI3MDI0NjksImV4cCI6MjA2ODI3ODQ2OX0.1feXzRZPXDMw1hfi8P-vq2bZfalB56BEQgq7K8nNnPg" );

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client( url, key, options );
        }

        public async Task InitializeAsync ()
        {
            await supabase.InitializeAsync();
        }
    }
}
