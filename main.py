

# Forwarder



# -*- coding: utf-8 -*-
"""
Spyder Editor



This is a temporary script file.
"""
import pandas as pd

data = pd.read_csv("F:\set.txt")
sentences_training = [doc for doc in data.iloc[:, 0]]
classification_training = [doc for doc in data.iloc[:, 1]]
from sklearn.feature_extraction.text import TfidfVectorizer

vectorizer = TfidfVectorizer(analyzer='word', lowercase=True)
sen_train_vector = vectorizer.fit_transform(sentences_training)
from sklearn.naive_bayes import GaussianNB

clf = GaussianNB()
model = clf.fit(X=sen_train_vector.toarray(), y=classification_training)
while True:
    a = input("ihbar giriniz")
    sen_test_vector = vectorizer.transform([a])
    ıhbar = model.predict(sen_test_vector.toarray())
    print(ıhbar)




