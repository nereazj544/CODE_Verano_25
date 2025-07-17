# LIBRERIAS

from flask import Flask, jsonify, request, render_template

from dotenv import load_dotenv
load_dotenv()

import os
from supabase import create_client



url: str = os.environ.get("SUPABASE_URL")
key: str = os.environ.get("SUPABASE_KEY")
supabase  = create_client(url, key)

tabla = "animal"

# HOST DE API
app = Flask(__name__) 
@app.route("/")
def home():
    items = supabase.table(tabla).select("*").execute()
    for item in items.data:
        item["id"] = str(item["id"])  # Convertir ID a cadena si es necesario
    return render_template("index.html", items=items.data)
    

# AÑADIR DATOS A LA BASE DE DATOS
@app.route("/add", methods=["POST"])
def update_db():
    nombre = request.form.get('name').capitalize()
    especie = request.form.get('specie').capitalize()
    url_img = request.form.get('url_img')

    if nombre and especie and url_img:
        data = {
            "nombre": nombre,
            "especie": especie,
            "url_img": url_img
        }
        query = supabase.table(tabla).insert(data).execute()
        return jsonify({'status': 'succes', 'message': 'CAMPOS AÑADIDOS CORRECTAMENTE'}), 400
    else: 
        return jsonify({'status': 'error', 'message': 'CAMPOS VACIOS'}), 400









# HOST RUN
if __name__ == '__main__':
    app.run(debug=True)