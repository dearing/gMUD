var ser = require('./mud_grpc_pb')
var mes = require('./mud_pb');
var grpc = require('grpc');

var cert = `-----BEGIN RSA PRIVATE KEY-----
MIIEpAIBAAKCAQEA3uVQ2ljrGMqM0zy5JF9xLsShfaj8rY4kvIqlCciOEzw1OMtx
E1JPWoVQx29NLMnzETFANTcfEaFwMStVBBSsaQNzb7srmadi2gUhOJDUvOSmBgpT
Yls6cDQ0izPS/VDznSX6qcuCc4c1/FI9PVprOTGyPHd/A6d35fr+KYZrIa+4J7pt
gGYt6DoFVHhOOkX1MWhUUZu8J+RRefqEsbH81/tJGU7pkZHEymQTHxPleUEKI+u6
VHbJecs807dViYhw8gdUvw6jEOYN3bjqALjPJ8744I6nhg9YGi9QNifqYr6337w8
vY4EqRXnNvAItcXh7ESOp62HuUKCWnJfpeOsBQIDAQABAoIBAQCQppshCGGR1iks
ERVJ0JKgOkVfSmKosz2OCh/uyHPDcehMMmLwmhMbeLcipk2cSnbu6lpz7pDAHVe0
4R0sJ8p34CBzGzHBZsqVGI0lq4AUEgLYmqzggLndBVQwHnLHqFhg3Lveo07GcLIN
TMWnYl2BYYn9CcOo+G6sFoYJJs2xrqQXcseh5fKUnxFDucLoyza6bOz5RbWSaAfs
keCZN1QB+epfsKJXhF0lRFN4sUcyzlres2lWJs6L3jUUgDao7BwKtt3YiGnSBMjs
orKh+iBrOEU6lRORya8iw9M8hVsYHId0c/Q5QmiVRaRK08Btx1YXNI7bNFrctqhD
MUTX4+vBAoGBAP5uKdc3XzeycUCczh9hv/A0eyzZsGOntNlhQpV1e5LEltJhrjVx
THtWI+5qWqeXu6F3OgUufk+8YJIrXDjmzHf+C/rId4Od1zuVBm4xpQAQX5qVZpvU
+dghnGDZrNWK9SG45U2lKOAzv9LlF0Jf9tKN9aDDgb7mmgoQkLBAsFE1AoGBAOBF
WRibikKn34V+X9xhWAShBzuSOAZCskBA3gppOupS3uiytcbENCPzeWk6S7rsCgxv
3PFfWBwEkgUjm6j+wyQ4PUsyJey/ZR4/vjURYrrBvg9Sx+Ugv+DKyum5qmBIs+b1
ca6UtF4Fc33TjY1Rl0BZUIYigo5UFyyM+UYgKZmRAoGBAJVldmgK+Xwo6Vs5N8cx
jJStHE6fnHVHumeSNpiwHVl22eC6vqJe3rvlPr/17zlNXT1YVtdID58eS85Ia6R1
0UX8BGjDYXoFKqavwNDfkbVR5/FLHK8QBYylX7920YeqSnn8qZhIDJJpkI9zOY8d
7j6AYOR/KCZCHd0fEPaNZXqpAoGAPQhCTeMORkN/HcoddlD7bg8Qc9K/8lw2PCwr
APRQNzKkPPldZKFCe0IoGU3nDBBuT6Ilo35J8R4BSuq80sm5+2Jes9cK4RnY/9li
/vgjQSW2fl8NzToTXa5yeBax2hAO/VxwOo13ZFrhai2nSP0aR0XHFynPE8Kop9QZ
hk78YzECgYAzJUSN8NaY9HGJvvxo4p+qzHeyUI8NFRJmwm7mfM7tzPdOXeOwVAeY
yHsbOxsWpxGWH0xlU+qYcI/oFGZmdma/GjivHPA4i2KqfRQPJN7dor0rTD7F8e7G
K5FH5aM7s4zIrMQATgdYIVnpP063ETaiUspyxbmpAdJ56uCHjmAJww==
-----END RSA PRIVATE KEY-----`


//var ssl_creds = grpc.credentials.createSsl(Buffer.from(cert, 'utf8'));
var client = new ser.GameClient('localhost:50051', grpc.credentials.createInsecure());
var request = new mes.LoginRequest();
request.setUsername("admin");
request.setPassword("password");
console.log(request)
var r = client.login(request, function (err, response) { console.log(err, response); });
