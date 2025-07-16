import os
from supabase import create_client, Client


url: str = os.environ.get()
key: str = os.environ.get()
supabase: Client = create_client(url, key)

