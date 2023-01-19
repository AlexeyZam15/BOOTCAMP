# pip install redis
import redis
import random

# with сам закрывает соединение,не нужно писать redis_server.Close()
with redis.Redis() as redis_server:
    redis_server.lpush("queue", random.randint(0, 10))
# lpush - left push, пушим слева
