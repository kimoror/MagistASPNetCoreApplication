﻿namespace PraktASPApp.Database.Models
{
    public class MessagesOdb
    {
        string Messages = "-- public.\"Messages\" definition\r\n\r\n-- Drop table\r\n\r\n-- DROP TABLE public.\"Messages\";\r\n\r\nCREATE TABLE public.\"Messages\" (\r\n\t\"Id\" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE),\r\n\t\"FromId\" int4 NOT NULL,\r\n\t\"ToId\" int4 NOT NULL,\r\n\t\"Title\" text NULL,\r\n\t\"Text\" text NULL,\r\n\t\"Date\" timestamptz NOT NULL,\r\n\t\"Status\" bool NOT NULL,\r\n\tCONSTRAINT \"PK_Messages\" PRIMARY KEY (\"Id\")\r\n);\r\nCREATE INDEX \"IX_Messages_FromId\" ON public.\"Messages\" USING btree (\"FromId\");\r\nCREATE INDEX \"IX_Messages_ToId\" ON public.\"Messages\" USING btree (\"ToId\");\r\n\r\n\r\n-- public.\"Messages\" foreign keys\r\n\r\nALTER TABLE public.\"Messages\" ADD CONSTRAINT \"FK_Messages_Users_FromId\" FOREIGN KEY (\"FromId\") REFERENCES public.\"Users\"(\"Id\") ON DELETE CASCADE;\r\nALTER TABLE public.\"Messages\" ADD CONSTRAINT \"FK_Messages_Users_ToId\" FOREIGN KEY (\"ToId\") REFERENCES public.\"Users\"(\"Id\") ON DELETE CASCADE;";
    }
}
