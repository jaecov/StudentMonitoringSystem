﻿ALTER TABLE [dbo].[sms_outbox_archive]
    ADD CONSTRAINT [PK_sms_outbox_archive] PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

