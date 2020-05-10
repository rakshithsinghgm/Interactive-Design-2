from chatterbot import ChatBot
from chatterbot.trainers import UbuntuCorpusTrainer
import inspect 

chatbot = ChatBot("Ron Obvious")

def chatbot_response(dialouge):
	trainer = UbuntuCorpusTrainer(chatbot)
	response = chatbot.get_response(dialouge)
	return response
"""
rsp = chatbot_response("Hey")
print("Type of rsp was ",type(rsp))

#print("Members of rsp are", inspect.getmembers(rsp))

print(" Type of Resp.text ",type(rsp.text))
"""
