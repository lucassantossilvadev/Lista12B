## Como executar
1. Abrir o projeto no Visual Studio
2. Rodar `dotnet restore` e depois `dotnet run`
3. Testar pelo Postman

## Usuário de teste
- usuário: admin
- senha: 123456

## Rotas
- POST /api/auth/login — recebe usuário e senha, retorna o token
- GET /api/usuario/perfil — rota protegida, precisa do token (Authorization: Bearer)

## Testes
1. Login válido → 200 + token
2. Login inválido → 401
3. Perfil sem token → 401
4. Perfil com token → 200
