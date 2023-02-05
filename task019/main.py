# Работа с Flask, Html, Css, Jinja

from flask import Flask, render_template
from random import randint


app = Flask(__name__)


@app.route('/')
# @app.route('/index')
# def main():
#     name = randint(0, 1)
#     return render_template('base.html', name=name)
def main():
    with open('file.txt', 'r', encoding='utf-8') as file:
        resultData = list()
        for line in file.readlines():
            resultData.append(tuple(line.split('\n')[0].split(';')))
    return render_template('base.html', data=resultData)


@app.route('/about')
def about():
    return render_template('about.html')


if __name__ == '__main__':
    app.run()
