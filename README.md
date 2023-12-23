## Worker Service

Este é um projeto simples de Worker Service para estudos. O Worker Service monitora o status de um site e envia uma notificação por e-mail se o site estiver offline

## Configuração

- No método ExecuteAsync do arquivo Worker.cs, defina a URL do site que deseja monitorar.
  ```sh
  var statusSite = await _httpService.ChecksStatusSite("http://localhost:3000");
  ```
- No método SendEmail do arquivo Email.cs, configure as credenciais do Gmail e o endereço de e-mail para receber notificações.
  ```sh
  var gmail = new EmailHelper("smtp.gmail.com", "seu_email@gmail.com", "SUA_SENHA");
  gmail.SendEmail(new List<string> { to }, subject, body, new());
  ```
- Compile e execute o projeto Worker Service para iniciar o monitoramento do site.
  ```sh
  dotnet run
  ```
## Observações

- Certifique-se de seguir práticas recomendadas de segurança ao lidar com credenciais.
- Personalize e expanda o projeto de acordo com seus objetivos de aprendizado.
- Sinta-se à vontade para usar este projeto como base para experimentar e aprender. Boa codificação!
