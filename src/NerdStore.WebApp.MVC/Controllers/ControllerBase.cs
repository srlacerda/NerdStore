﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        //private readonly DomainNotificationHandler _notifications;
        //private readonly IMediatorHandler _mediatorHandler;

        //protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");
        protected Guid ClienteId = Guid.Parse("cb878264-cae9-4f1f-9871-3134e94fe49e");
        //protected ControllerBase(INotificationHandler<DomainNotification> notifications,
        //                         IMediatorHandler mediatorHandler)
        //{
        //    _notifications = (DomainNotificationHandler)notifications;
        //    _mediatorHandler = mediatorHandler;
        //}

        //protected bool OperacaoValida()
        //{
        //    return !_notifications.TemNotificacao();
        //}

        //protected IEnumerable<string> ObterMensagensErro()
        //{
        //    return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
        //}

        //protected void NotificarErro(string codigo, string mensagem)
        //{
        //    _mediatorHandler.PublicarNotificacao(new DomainNotification(codigo, mensagem));
        //}
    }
}
