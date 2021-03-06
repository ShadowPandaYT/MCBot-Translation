﻿using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Spanish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Bot requiere permiso \" Enlazar Enlaces \"",
                AdminOnly = "Usted no es un administrador del servidor",
                PlayerNotFound = "Jugador {0} extraviado",
                ApiError = "Error de API",
                EnterIP = "Introduzca un IP",
                InvalidIP = "IP no válida",
                Cooldown = "Estás en cooldown por 1 minutos!",
                EnableQuery = "El servidor de Minecraft no tiene enable-query establecido en server.properties",
                ListNoServers = "Esta comunidad no tiene servidores",
                UnknownArg = "Argumento desconocido",
                TextLimit = "El texto no puede tener más de 22 letras / números",
                RequireAttachFiles = "Bot requiere adjuntar permiso de archivos",
                UnknownWiki = "Artículo wiki desconocido"
            },

            MainCommands = new TMainCommands
            {
                BotInfo = "Bot info and stats",
                Quiz = "Minecraft quiz :D",
                Color = "MC color codes",
                NameHistory = "Historia del nombre de cuenta de MC",
                UserProfile = "Your Minecraft account, skin and stats",
                Ping = "Hacer ping a un servidor",
                Version = "Minecraft version info",
                Rcon = "Remote console for your Minecraft server",
                Achievement = "Obtener un logro",
                Playing = "Les gens qui jouent à Minecraft",
                List = "Listar servidores comunitarios",
                Admin = "Comandos de administración de la comunidadn",
                Invite = "Obtener la invitación bot"
            },

            Main = new TMain
            {
                HelpFooter = "Hay algunos comandos ocultos también ;)",
                MultiMC = "MultiMC le permite administrar y lanzar varias versiones con una instalación fácil de forge / mods",
                PleaseWait = "Por favor, espere mientras hago ping",
                ServerAdminUse = "El administrador del servidor debería usar",
                StoleSkin = "Robó una piel",
                NameOnlyOne = "El jugador {0} sólo tiene 1 nombre en los registros",
                PlayingMinecraft = "Personas jugando Minecraft",
                Hi = "Hola",
                BotDesc = "Si tiene algún problema, sugerencias o traducciones de idiomas, póngase en contacto conmigo",
                First = "primero"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hola, has encontrado un comando secreto :D",
                Herobrine = "Siempre observándote...",
                Notch = "Minecraft fue creado por Notch aka Markus Persson"
            },

            Wiki = new TWiki
            {
                Blocks = "bloques",
                Unknown = "Desconocido",
                Player = "Jugador",
                Players = "Jugadores",
                Attack = "Ataque",
                Easy = "Fácil",
                Hard = "Difícil",
                Health = "Salud",
                Height = "Altura",
                Width = "Anchura",
            },

            Profile = new TProfile
            {
                Badges = "Insignias",
                BadgeInfo = "Información de la insignia",
                InvalidUserID = "ID de usuario invalido",
                UnknownUser = "No se pudo encontrar usuario",
                NotInServer = "Usted no está en el servidor",
                SetMCName = "Para configurar su cuenta de Minecraft, use"
            },

            AdminCommands = new TAdminCommands
            {
                MCRole = "Create a Minecraft role for verified users",
                AutoPost = "Auto post your Minecraft server status",
                AddServer = "Ajouter un serveur MC à cette liste de guilde",
                RemoveServer = "Supprimez un serveur MC de cette liste de guilde",
                SetPrefix = "Set Custom Prefix",
                ResetPrefix = "Remove Custom Prefix"
            },

            Admin = new TAdmin
            {
                WantTranslation = "¿Quiere traducir un idioma? Contacto",
                ChangeLang = "Cambiar idioma de la comunidad",
                UseList = "Utilice mc/list para obtener una lista de estos servidores de los minecraft de los gremios",
                AddServer = "Introduzca una etiqueta, ip y nombre",
                AddServerAdded = "Añadido servidor {0} a la lista de los gremios",
                AddServerAlready = "Este servidor ya está en la lista",
                DelServerEnter = "Eliminar un servidor con",
                DelServerNone = "Este servidor no está en la lista",
                DelServerDeleted = "Servidor eliminado {0} de la lista de gremios",
                PrefixReset = "Uso de reinicio del prefijo del servidor mc/",
                LanguageSet = "Conjunto de idioma comunitario"
            }

        };
    }
}
