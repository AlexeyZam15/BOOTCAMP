import redis

with redis.Redis() as redis_client:
    value = redis_client.brpop("queue")
    # rpop выгружает данные, ошибка если данных нет
    # brpop выгружает данные, но ждёт если данных нет

print(int(value[1]))
