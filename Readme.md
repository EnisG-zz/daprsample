```
C:\Users\egunesen\source\repos\Dapr\Sample>tye deploy -i
```

Change orderservice Type=LoadBalancer and Port=8011 
"kubectl edit svc orderservice" 

```
super@egunesen0004:/c/Users/egunesen$ k get svc
NAME                    TYPE           CLUSTER-IP       EXTERNAL-IP   PORT(S)                               AGE
inventoryservice        ClusterIP      10.103.18.172    <none>        80/TCP                                22m
inventoryservice-dapr   ClusterIP      None             <none>        80/TCP,50001/TCP,50002/TCP,9090/TCP   22m
kubernetes              ClusterIP      10.96.0.1        <none>        443/TCP                               39h
orderservice            LoadBalancer   10.101.40.159    localhost     8011:30698/TCP                        22m
orderservice-dapr       ClusterIP      None             <none>        80/TCP,50001/TCP,50002/TCP,9090/TCP   22m
redis-headless          ClusterIP      None             <none>        6379/TCP                              15h
redis-master            ClusterIP      10.100.29.183    <none>        6379/TCP                              15h
redis-slave             ClusterIP      10.105.110.230   <none>        6379/TCP                              15h
```
