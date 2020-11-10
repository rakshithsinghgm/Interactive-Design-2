from chatterbot import ChatBot
from chatterbot.trainers import UbuntuCorpusTrainer
import inspect 

chatbot = ChatBot("Ron Obvious")

def chatbot_response(dialouge):
	trainer = UbuntuCorpusTrainer(chatbot)
	response = chatbot.get_response(dialouge)
	return response
