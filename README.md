This repo houses "ABP AI Chat BOT" investigations to create an MVP app. 
* MarkdownPdfConverter: This console app takes ABP Docs as markdown from your local filesystem and creates a single PDF with all the combinations of parameters.
* AbpSupportQuestionsFetcher: This console app creates a PDF with ABP Support questions. We will use only the accepted answers to train the AI model.
* AbpChatBot: This console app uses AnythingLLM as WebAPI. ChatBot will communicate with AnythingLLM. We'll train AnythingLLM workspace via RAG.  For training, we'll provide ABP-accepted support tickets, ABP Docs, and ABP Framework source code. We can add resources in the future. To be able to use AnythingLLM, create an ApiKey on AnythingLLM and set it in the AbpChatBot config.
