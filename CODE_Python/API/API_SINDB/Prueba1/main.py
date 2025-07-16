from flask import Flask, jsonify, request

# HOST DE API
app = Flask(__name__) 

@app.route("/")
def root():
    return "Home"

'''
ENPOINTS
GET -> OBTENER DATOS
POST -> CREAR DATOS
PUT -> ACTUALIZAR DATOS
DELETE -> ELIMINAR DATOS
'''

@app.route("/users/<user_id>")
def get_user(user_id):
    user = {
        "id": user_id,
        "name": "John Doe"}


if __name__ == '__main__':
    app.run(debug=True)