from flask import Flask
from demo import chatbot_response 


app = Flask(__name__)
feedback_response = ""

@app.route('/')
def index():
	ret = 'Server works'
	return ret

@app.route('/response/<line>')
def chat(line):
	global feedback_response
	response = chatbot_response(line)
	feedback_response = response.text
	return response.text	

