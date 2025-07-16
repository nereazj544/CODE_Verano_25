# LIBRERIAS

from flask import Flask, jsonify, request, render_template

from dotenv import load_dotenv
load_dotenv()

import os
from supabase import create_client



url: str = os.environ.get("SUPABASE_URL")
key: str = os.environ.get("SUPABASE_KEY")
supabase  = create_client(url, key)

# HOST DE API
app = Flask(__name__) 
@app.route("/")
def home():
    items = supabase.table("animal").select("*").execute()
    for item in items.data:
        item["id"] = str(item["id"])  # Convertir ID a cadena si es necesario
    return render_template("index.html", items=items.data)
    











# HOST RUN
if __name__ == '__main__':
    app.run(debug=True)