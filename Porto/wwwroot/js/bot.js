const chatbotData = {
    live: {
        name: {
            en: "Live",
            pt: "Viver"
        },
        subcategories: [
            {
                id: "housing",
                name: {
                    en: "Housing Opportunities",
                    pt: "Oportunidades de Habitação"
                },
                description: {
                    en: "Renting options",
                    pt: "Opções de aluguel"
                },
                questions: [
                    {
                        id: "housing-1",
                        question: {
                            en: "I'm looking for a house to rent in Campanhã.",
                            pt: "Procuro casa para alugar em Campanhã."
                        },
                        answer: {
                            en: "In Campanhã, you can find various options for houses to rent. You can check platforms like Idealista, Imovirtual, or get in touch with the Parish Council (Junta de Freguesia) or the Porto City Hall, which sometimes have information about affordable housing programs.",
                            pt: "Em Campanhã, podes encontrar várias opções de casas para alugar. Podes consultar plataformas como o Idealista, Imovirtual ou entrar em contacto com a Junta de Freguesia, ou a Câmara Municipal do Porto, que por vezes têm informação sobre programas de arrendamento acessível."
                        }
                    },
                    {
                        id: "housing-2",
                        question: {
                            en: "Is there any temporary accommodation in Campanhã for emergency situations?",
                            pt: "Existe algum alojamento temporário em Campanhã para situações de emergência?"
                        },
                        answer: {
                            en: "Yes. In emergency cases, such as eviction or homelessness, the Porto City Hall, through its Social Housing Division and the NPISA (Planning and Intervention Center for Homeless People), may provide temporary accommodation. I recommend contacting local social services or the Campanhã Parish Council for immediate support.",
                            pt: "Sim. Em casos de emergência, como despejo ou situação de sem-abrigo, a Câmara Municipal do Porto, através da sua Divisão de Habitação Social e do NPISA (Núcleo de Planeamento e Intervenção Sem-Abrigo), pode disponibilizar alojamento temporário. Aconselho que contactes os serviços sociais locais ou a Junta de Freguesia de Campanhã para apoio imediato."
                        }
                    },
                    {
                        id: "housing-3",
                        question: {
                            en: "Am I eligible for social housing? How can I apply for social housing in Campanhã?",
                            pt: "Tenho direito à habitação social? Como posso candidatar-me a habitação social em Campanhã?"
                        },
                        answer: {
                            en: "Social housing is intended for individuals and families facing economic hardship. To find out if you are eligible, you should check the criteria defined by the Porto City Hall, such as income, household composition, and current housing situation. You can apply through the Porto City Hall website or in person by filling out an application form and submitting the required documents.",
                            pt: "A habitação social destina-se a pessoas e famílias em situação de carência económica. Para saberes se tens direito, deves verificar os critérios definidos pela Câmara Municipal do Porto, como rendimento, composição do agregado familiar e situação habitacional atual. Para se candidatar, podes fazê-lo através do site da CMP ou presencialmente, preenchendo um formulário e apresentando os documentos necessários."
                        }
                    },
                    {
                        id: "housing-4",
                        question: {
                            en: "Is there financial assistance to help pay rent?",
                            pt: "Existe ajuda financeira para pagar a renda?"
                        },
                        answer: {
                            en: "Yes. There are support programs such as the Rent Support Program (Programa de Apoio ao Arrendamento - PAA) or Porta 65 (for young people). These types of assistance are granted based on household income and the amount of rent. I suggest checking the website of the Porto City Hall or the Housing and Urban Rehabilitation Institute (IHRU) to see which program applies to your situation.",
                            pt: "Sim. Existem apoios como o Programa de Apoio ao Arrendamento (PAA) ou o Porta 65 (para jovens). Estes apoios são atribuídos com base no rendimento do agregado familiar e no valor da renda. Sugiro que consultes o site da Câmara Municipal ou do Instituto da Habitação e da Reabilitação Urbana (IHRU) para ver qual se aplica à sua situação."
                        }
                    }
                ]
            },
        ]
    },
    education: {
        name: {
            en: "Education",
            pt: "Educação"
        },
        subcategories: [
             {
                id: "education",
                name: {
                    en: "Education",
                    pt: "Educação"
                },
                description: {
                    en: "Schools for children and adults",
                    pt: "Escolas para crianças e adultos"
                },
                questions: [
                    {
                        id: "education-1",
                        question: {
                            en: "How can I enroll my child in a school in Campanhã?",
                            pt: "Como posso inscrever o meu filho numa Escola em Campanhã?"
                        },
                        answer: {
                            en: "You can register through the Portal das Matrículas (https://portaldasmatriculas.edu.gov.pt/) or directly at the school you are interested in. You will need the child's documents (such as citizen card, health service number, etc.) and proof of address. If you have any questions, the school can help you complete the process.",
                            pt: "Podes fazer a inscrição através do Portal das Matrículas (https://portaldasmatriculas.edu.gov.pt/) ou diretamente na escola que pretendes. Vais precisar dos documentos da criança ou jovem (como cartão de cidadão, número de utente, etc.) e do comprovativo de morada. Se tiveres dúvidas, a escola pode ajudar-te a preencher tudo."
                        }
                    },
                    {
                        id: "education-2",
                        question: {
                            en: "Can immigrant children enroll in school?",
                            pt: "As crianças imigrantes podem inscrever-se na Escola?"
                        },
                        answer: {
                            en: "Yes, all children have the right to education, even if their parents' residency status is not yet regularized. You just need to go to a public school with any available documents. The school will guide and support you through the enrollment process.",
                            pt: "Sim, todas as crianças têm direito à educação, mesmo que a situação dos pais ainda não esteja regularizada. Basta ir a uma escola pública com os documentos disponíveis. A escola vai orientar e apoiar no processo."
                        }
                    },
                    {
                        id: "education-3",
                        question: {
                            en: "Is there support for students from low-income families?",
                            pt: "Existe apoio para estudantes de famílias com baixos rendimentos?"
                        },
                        answer: {
                            en: "Yes, there is. You can apply for support through Ação Social Escolar (School Social Assistance), which can help with meals, school supplies, and transportation. To apply, you need to present your income tax statement (IRS) or another proof of income at the school office.",
                            pt: "Existe, sim. É possível pedir apoio através da Ação Social Escolar, que pode ajudar com refeições, material e transporte. Para isso, é necessário apresentar a declaração de IRS ou outro comprovativo de rendimento na secretaria da escola."
                        }
                    },
                    {
                        id: "education-4",
                        question: {
                            en: "Are there free training courses in Campanhã?",
                            pt: "Há formações gratuitas em Campanhã?"
                        },
                        answer: {
                            en: "Yes, in Campanhã there are several free training opportunities offered by local associations, the Porto City Hall, the IEFP (Institute of Employment and Vocational Training), and Centros Qualifica. There are courses in areas such as theatre, IT, languages, digital marketing, and more — available both in-person and online.",
                            pt: "Sim, em Campanhã há várias formações gratuitas promovidas por associações locais, a Câmara Municipal do Porto, o IEFP e Centros Qualifica. Existem cursos nas áreas de teatro, informática, línguas, marketing digital, entre outros, tanto presenciais como online."
                        }
                    },
                    {
                        id: "education-5",
                        question: {
                            en: "I want to finish 12th grade, how can I do it?",
                            pt: "Quero tirar o 12.º ano, como posso fazer?"
                        },
                        answer: {
                            en: "You can complete the 12th grade through EFA courses (Education and Training for Adults), recurrent education, or the RVCC process, which recognizes your professional experience. The best option is to go to a Centro Qualifica, where they will explain everything and help you choose the path that suits you best.",
                            pt: "Podes completar o 12.º ano através de cursos EFA, ensino recorrente ou pelo processo RVCC, que reconhece a tua experiência profissional. O ideal é ires a um Centro Qualifica, onde te explicam tudo e te ajudam a escolher o melhor caminho para ti."
                        }
                    }
                ]
            },
        ]
    },
    
    social: {
        name: {
            en: "Social Help",
            pt: "Ajuda Social"
        },
        subcategories: [  {
                id: "social",
                name: {
                    en: "Social Help",
                    pt: "Ajuda Social"
                },
                description: {
                    en: "Emergency & social attendance",
                    pt: "Atendimento de emergência e social"
                },
                questions: [
                    {
                        id: "social-1",
                        question: {
                            en: "Where can I ask for urgent help if I need immediate social support?",
                            pt: "Onde posso pedir ajuda urgente se necessitar de apoio social imediato?"
                        },
                        answer: {
                            en: "If you need urgent social support, you can go to the Social Action Services of the Porto City Hall or the Campanhã Parish Council. You can also contact the Porto District Social Security Center for immediate help.",
                            pt: "Se precisas de apoio social urgente, podes dirigir-te aos Serviços de Ação Social da Câmara Municipal do Porto ou à Junta de Freguesia de Campanhã. Também podes contactar o Centro Distrital da Segurança Social do Porto para ajuda imediata."
                        }
                    },
                    {
                        id: "social-2",
                        question: {
                            en: "Is there a helpline for emergency social situations?",
                            pt: "Existe algum número que eu possa ligar em caso de emergência social?"
                        },
                        answer: {
                            en: "Yes. You can call the National Social Emergency Line – 144 (available 24/7), which refers urgent cases to the appropriate entities, such as shelters, food assistance, or psychological support.",
                            pt: "Sim. Podes ligar para a Linha Nacional de Emergência Social – 144 (disponível 24h), que encaminha casos urgentes para as entidades competentes, como abrigos, alimentação ou apoio psicológico."
                        }
                    },
                    {
                        id: "social-3",
                        question: {
                            en: "Are there institutions in Campanhã that help people in vulnerable situations?",
                            pt: "Há instituições em Campanhã que ajudam pessoas em situação de vulnerabilidade?"
                        },
                        answer: {
                            en: "Yes. Several institutions operate in Campanhã, such as Cerporto, Benéfica e Previdente, the Porto Cerebral Palsy Association, the Diocese of Porto's Social Work, and other private social solidarity institutions (IPSS) that provide food, social, and housing support.",
                            pt: "Sim. Em Campanhã atuam várias instituições como a Cerporto, a Benéfica e Previdente, a Associação do Porto de Paralisia Cerebral, a Obra Diocesana do Porto e outras IPSS que prestam apoio alimentar, social e habitacional."
                        }
                    },
                    {
                        id: "social-4",
                        question: {
                            en: "Is there a free canteen in Campanhã?",
                            pt: "Existe algum refeitório gratuito em Campanhã?"
                        },
                        answer: {
                            en: "Yes. Some local institutions offer free or low-cost meals. The Campanhã Parish Council can direct you to the nearest one.",
                            pt: "Sim. Algumas instituições locais oferecem refeições gratuitas ou a baixo custo. A Junta de Freguesia de Campanhã pode indicar-lhe o mais próximo."
                        }
                    },
                    {
                        id: "social-5",
                        question: {
                            en: "How can I receive a food basket?",
                            pt: "Como posso receber um cabaz alimentar?"
                        },
                        answer: {
                            en: "You can request a food basket from your Parish Council, Social Action Service, or institutions such as Cáritas, the Red Cross, or local food banks. An assessment of your economic situation will be required.",
                            pt: "Pode solicitar um cabaz alimentar junto da sua Junta de Freguesia, Serviço de Ação Social, ou de instituições como a Cáritas, Cruz Vermelha ou bancos alimentares locais. Será necessário fazer uma avaliação da sua situação económica."
                        }
                    },
                    {
                        id: "social-6",
                        question: {
                            en: "How can I get free psychological support in Campanhã?",
                            pt: "Como posso ter apoio psicológico gratuito em Campanhã?"
                        },
                        answer: {
                            en: "Free psychological support is available through the National Health Service (via the health center), as well as through some local IPSS. The Parish Council or the local Family Health Unit can refer you. Do you need help scheduling an appointment?",
                            pt: "Existe apoio psicológico gratuito através do Serviço Nacional de Saúde (via centro de saúde), e também por algumas IPSS da zona. A Junta de Freguesia ou a Unidade de Saúde Familiar local poderá encaminhar-te. Precisas de ajuda para marcar?"
                        }
                    },
                    {
                        id: "social-7",
                        question: {
                            en: "Is there a helpline for emotional support?",
                            pt: "Existe alguma linha telefónica de apoio emocional?"
                        },
                        answer: {
                            en: "Yes. You can call SOS Voz Amiga – 213 544 545 or the SNS Psychological Support Helpline – 808 24 24 24. They are free, confidential, and available to listen to you.",
                            pt: "Sim. Podes ligar para o SOS Voz Amiga – 213 544 545 ou para a Linha de Apoio Psicológico do SNS – 808 24 24 24. São gratuitas, confidenciais e disponíveis para te ouvir."
                        }
                    },
                    {
                        id: "social-8",
                        question: {
                            en: "How can I apply for a visa to study or work in Portugal?",
                            pt: "Como posso pedir um visto para estudar ou trabalhar em Portugal?"
                        },
                        answer: {
                            en: "To study or work in Portugal, you should apply for a visa at the Portuguese consulate in your home country. To study: apply for a residence visa for studies. To work: apply for a work visa (residence for professional activity). You will need a contract, an acceptance letter (in the case of studies), and proof of financial means.",
                            pt: "Para estudar ou trabalhar em Portugal, deves pedir um visto no consulado português do seu país de origem. Para estudar: pede um visto de residência para estudos. Para trabalhar: pede um visto de trabalho (residência para exercício de atividade profissional). Vais precisar de contrato, carta de aceitação (no caso de estudos) e prova de meios de subsistência."
                        }
                    },
                    {
                        id: "social-9",
                        question: {
                            en: "Can I bring my family to Portugal?",
                            pt: "Posso trazer a minha família para Portugal?"
                        },
                        answer: {
                            en: "Yes. You can bring your family through the family reunification process once you have a valid residence permit in Portugal. The application is made at the Immigration and Mobility Agency (AIMA). You will need to provide proof of accommodation, financial means, and your family relationship.",
                            pt: "Sim. Podes trazer a sua família através do processo de reagrupamento familiar, depois de ter autorização de residência válida em Portugal. O pedido é feito na Agência para a Imigração e Mobilidade (AIMA). Terás de comprovar habitação, meios financeiros e o grau de parentesco."
                        }
                    },
                    {
                        id: "social-10",
                        question: {
                            en: "What documents are required to apply for residence in Portugal?",
                            pt: "Quais os documentos necessários para pedir residência em Portugal?"
                        },
                        answer: {
                            en: "You will need the following documents to apply for a residence permit: Valid passport, Appropriate visa (work, study, etc.), Proof of accommodation in Portugal, Proof of income or employment contract, Criminal record from your home country, Two passport-sized photos, Completed application form. The process is done at AIMA (formerly SEF). Do you need help scheduling an appointment or finding the form?",
                            pt: "Vais precisar dos seguintes documentos para pedir autorização de residência: Passaporte válido, Visto adequado (trabalho, estudo, etc.), Comprovativo de alojamento em Portugal, Comprovativo de rendimentos ou contrato de trabalho, Registo criminal do país de origem, Duas fotografias tipo passe, Formulário de pedido preenchido. O processo é feito junto da AIMA (ex-SEF). Precisas de ajuda para marcar uma consulta ou encontrar o formulário?"
                        }
                    }
                ]
            },
        ]
    },
    health: {
        name: {
            en: "Health",
            pt: "Saúde"
        },
        subcategories: [      {
                id: "health",
                name: {
                    en: "Health",
                    pt: "Saúde"
                },
                description: {
                    en: "Local services",
                    pt: "Serviços locais"
                },
                questions: [
                    {
                        id: "health-1",
                        question: {
                            en: "What is the closest hospital to Campanhã?",
                            pt: "Qual é o hospital mais próximo de Campanhã?"
                        },
                        answer: {
                            en: "The closest hospital to Campanhã is the Hospital de São João, located in the Paranhos parish, in Porto. It is a public reference hospital in the Northern region and is well connected by public transport, including the STCP bus line 404, which directly links the Campanhã Intermodal Terminal to the hospital in about 20 minutes.",
                            pt: "O hospital mais próximo de Campanhã é o Hospital de São João, que fica na freguesia de Paranhos, no Porto. É um hospital público de referência na região Norte e está bem ligado por transportes, incluindo a linha 404 da STCP, que liga diretamente o Terminal Intermodal de Campanhã ao hospital em cerca de 20 minutos."
                        }
                    },
                    {
                        id: "health-2",
                        question: {
                            en: "Are there affordable clinics or social support?",
                            pt: "Existem clínicas com preços acessíveis ou apoio social?"
                        },
                        answer: {
                            en: "Yes. In Campanhã and Porto, you can find clinics with social prices or free support through: The National Health Service (SNS), through your local health center; Social clinics promoted by IPSS or Misericórdias; Some universities (such as the University of Porto) offer consultations at reduced prices in areas like psychology, dentistry, and physiotherapy. Would you like me to provide details of a specific clinic or the contact information for your local health center?",
                            pt: "Sim. Em Campanhã e no Porto, pode encontrar clínicas com preços sociais ou apoio gratuito através de: O Serviço Nacional de Saúde (SNS), através do seu centro de saúde local; Clínicas sociais promovidas por IPSS ou Misericórdias; Algumas universidades (como a do Porto) que oferecem consultas a preços reduzidos em áreas como psicologia, medicina dentária e fisioterapia. Deseja que lhe indique uma clínica específica ou os contactos do centro de saúde da sua zona?"
                        }
                    }
                ]
            },
        ]
    },
    mobility: {
        name: {
            en: "Mobility",
            pt: "Mobilidade"
        },
        subcategories: [      {
                id: "mobility",
                name: {
                    en: "Mobility",
                    pt: "Mobilidade"
                },
                description: {
                    en: "Public Transport Support",
                    pt: "Apoio ao Transporte Público"
                },
                questions: [
                    {
                        id: "mobility-1",
                        question: {
                            en: "Which buses can I use in Campanhã?",
                            pt: "Quais autocarros posso usar em Campanhã?"
                        },
                        answer: {
                            en: "In Campanhã, several STCP (Sociedade de Transportes Colectivos do Porto) bus lines operate. The most common are 205, 207, 400, 401, 402, and 800, which connect Campanhã to other areas of Porto. You can check the schedules and routes on the MOVE-ME.AMP app or on the STCP website.",
                            pt: "Em Campanhã circulam várias linhas da STCP (Sociedade de Transportes Colectivos do Porto). As mais comuns são a 205, 207, 400, 401, 402 e 800, que ligam Campanhã a outras zonas do Porto. Podes consultar os horários e rotas na app MOVE-ME.AMP ou no site da STCP."
                        }
                    },
                    {
                        id: "mobility-2",
                        question: {
                            en: "Where can I use shared bicycles or scooters in Campanhã?",
                            pt: "Onde posso usar bicicletas ou trotinetes partilhadas em Campanhã?"
                        },
                        answer: {
                            en: "You can find shared bicycles and scooters (such as Bird, Bolt, or Gira) near Campanhã Station and along some main avenues. The area has bike lanes and dedicated spaces. Simply use the app of the provider to locate and unlock the vehicle.",
                            pt: "Podes encontrar bicicletas e trotinetes partilhadas (como Bird, Bolt ou Gira) perto da Estação de Campanhã e em algumas avenidas principais. A zona tem ciclovias e espaços dedicados. Basta usar a app da marca para localizar e desbloquear o veículo."
                        }
                    },
                    {
                        id: "mobility-3",
                        question: {
                            en: "Do the metro or trains have accessibility for people with reduced mobility?",
                            pt: "O metro ou comboio têm acessibilidade para pessoas com mobilidade condicionada?"
                        },
                        answer: {
                            en: "Yes. Both the Porto Metro and the CP (Comboios de Portugal) trains at Campanhã station have adapted access, elevators, and ramps, although some stations may have limitations. It is advisable to check in advance on the Porto Metro or CP websites.",
                            pt: "Sim. Tanto o Metro do Porto como os comboios da CP (Comboios de Portugal) em Campanhã têm acessos adaptados, elevadores e rampas, embora algumas estações possam ter limitações. É aconselhável verificar antecipadamente no site da Metro do Porto ou da CP."
                        }
                    },
                    {
                        id: "mobility-4",
                        question: {
                            en: "Are there adapted transport options for people with disabilities in Campanhã?",
                            pt: "Existem transportes adaptados para pessoas com deficiência em Campanhã?"
                        },
                        answer: {
                            en: "Yes, STCP and other public transport operators offer adapted vehicles. For more information, you can request support through the STCP customer service line. Some local social organizations also provide these services.",
                            pt: "Sim, a STCP e outras operadoras de transporte público oferecem veículos adaptados. Para mais informações, é possível solicitar apoio através da linha de atendimento da STCP. Algumas organizações sociais da zona também o disponibilizam."
                        }
                    }
                ]
            }
        ]
    },
    work: {
        name: {
            en: "Work",
            pt: "Trabalho"
        },
        subcategories: [
            {
                id: "training",
                name: {
                    en: "Professional Training",
                    pt: "Formação Profissional"
                },
                description: {
                    en: "Training opportunities",
                    pt: "Oportunidades de formação"
                },
                questions: [
                    {
                        id: "training-1",
                        question: {
                            en: "Where can I take professional training in Campanhã?",
                            pt: "Onde posso fazer formações profissionais em Campanhã?"
                        },
                        answer: {
                            en: "In Campanhã, you can find professional training at the Porto Employment and Professional Training Center (IEFP), as well as at certified training centers such as CENFIM, CESAE Digital, or FORAVE. Some vocational schools also offer courses in this area.",
                            pt: "Em Campanhã, podes encontrar formações profissionais no Centro de Emprego e Formação Profissional do Porto (IEFP), e também em centros de formação certificada como a CENFIM, CESAE Digital ou FORAVE. Algumas escolas profissionais também oferecem cursos nesta zona."
                        }
                    },
                    {
                        id: "training-2",
                        question: {
                            en: "Can I finish 9th or 12th grade and take training at the same time?",
                            pt: "Posso terminar o 9.º ou 12.º e fazer formação ao mesmo tempo?"
                        },
                        answer: {
                            en: "Yes. You can enroll in EFA (Education and Training for Adults) courses or in the Recognition, Validation, and Certification of Competencies (RVCC) program, which allows you to complete your studies and obtain professional qualification simultaneously. These courses are available at Centros Qualifica, including in Campanhã or nearby areas.",
                            pt: "Sim. Podes inscrever-se em cursos EFA (Educação e Formação de Adultos) ou em modalidades de Reconhecimento, Validação e Certificação de Competências (RVCC), que permitem concluir os estudos e obter qualificação profissional em simultâneo. Estes cursos estão disponíveis em Centros Qualifica, inclusive em Campanhã ou zonas próximas."
                        }
                    },
                    {
                        id: "training-3",
                        question: {
                            en: "Are there training programs offered by associations in Campanhã?",
                            pt: "Há formações oferecidas por associações em Campanhã?"
                        },
                        answer: {
                            en: "Yes. Some local associations and IPSS offer free or funded training programs, such as the Escola Profissional de Campanhã, among others. These training programs cover areas like Health and Hygiene, Occupational Safety, Commerce, Hospitality, and more.",
                            pt: "Sim. Algumas associações locais e IPSS promovem formações gratuitas ou financiadas, como a Escola Profissional de Campanhã, entre outras. Estas formações incluem áreas como Saúde e Higiene e Segurança no Trabalho, Comércio, Hotelaria, entre outros."
                        }
                    },
                    {
                        id: "training-4",
                        question: {
                            en: "How can I obtain a certificate of my professional skills?",
                            pt: "Como posso obter um certificado das minhas competências profissionais?"
                        },
                        answer: {
                            en: "You can obtain a professional certificate through a Centro Qualifica, which evaluates your work experience and skills. If you have practical experience, even without formal training, you may be certified in the corresponding areas.",
                            pt: "Podes obter um certificado profissional através de um Centro Qualifica, que avalia a sua experiência de trabalho e competências. Se tiveres experiência prática, mesmo sem formação formal, podes ser certificado nas áreas correspondentes."
                        }
                    },
                    {
                        id: "training-5",
                        question: {
                            en: "I have a disability. Are there training courses I can attend in Campanhã?",
                            pt: "Tenho deficiência. Existem cursos de formação que eu possa frequentar em Campanhã?"
                        },
                        answer: {
                            en: "Yes. IEFP offers specific training programs for people with disabilities and impairments. In addition, there are specialized organizations, such as the Porto Cerebral Palsy Association, that offer adapted courses and support for integration into the job market.",
                            pt: "Sim. O IEFP tem programas específicos de formação para pessoas com deficiência e incapacidade. Além disso, existem entidades especializadas, como a Associação do Porto de Paralisia Cerebral, que oferecem cursos adaptados e apoio à integração no mercado de trabalho."
                        }
                    }
                ]
            },
            {
                id: "jobs",
                name: {
                    en: "Job Opportunities",
                    pt: "Oportunidades de Emprego"
                },
                description: {
                    en: "Finding work",
                    pt: "Encontrar trabalho"
                },
                questions: [
                    {
                        id: "jobs-1",
                        question: {
                            en: "Where can I find job offers in Campanhã?",
                            pt: "Onde posso ver ofertas de emprego em Campanhã?"
                        },
                        answer: {
                            en: "You can check job offers on the IEFP website (iefponline.pt), on platforms like Net-Empregos, Indeed, or Sapo Emprego, and on the notice boards of the Campanhã Parish Council. If you're registered with the Gabinete de Inserção Profissional(GIP), you can receive offers of interest directly in your email!",
                            pt: "Podes consultar ofertas de emprego no site do IEFP (iefponline.pt), em plataformas como Net-Empregos, Indeed ou Sapo Emprego, e nos painéis de anúncios da Junta de Freguesia de Campanhã. Se tiveres inscrito no Gabinete de Inserção Profissional (GIP), podes receber as ofertas do teu interesse no teu email!"
                        }
                    }
                ]
            },
            {
                id: "support",
                name: {
                    en: "Support to Find Job",
                    pt: "Apoio para Encontrar Emprego"
                },
                description: {
                    en: "Assistance with job search",
                    pt: "Assistência na procura de emprego"
                },
                questions: [
                    {
                        id: "support-1",
                        question: {
                            en: "Can I find a job with support from the Parish Council or other local associations?",
                            pt: "Posso encontrar emprego com apoio da Junta de Freguesia ou outras associações locais?"
                        },
                        answer: {
                            en: "Yes. The Campanhã Parish Council and the Gabinetes de Inserção Profissional (GIP) offer support in job searching. It's worth visiting or calling them to learn about active job offers.",
                            pt: "Sim. A Junta de Freguesia de Campanhã e os Gabinetes de Inserção Profissional (GIP) apoiam na procura de emprego. Vale a pena visitar ou ligar para conhecer as ofertas ativas."
                        }
                    },
                    {
                        id: "support-2",
                        question: {
                            en: "How can I get support to search for a job?",
                            pt: "Como posso ter apoio para procurar emprego?"
                        },
                        answer: {
                            en: "You can count on free support from: Gabinetes de Inserção Profissional (GIP), Centros Qualifica, and the IEFP itself, which offers help in creating a CV, preparing for interviews, and searching for opportunities. Would you like me to help locate the nearest GIP?",
                            pt: "Podes contar com apoio gratuito de: Gabinetes de Inserção Profissional (GIP), Centros Qualifica, O próprio IEFP, que oferece ajuda para elaborar CV, preparar entrevistas e procurar oportunidades. Posso ajudar a localizar o GIP mais próximo?"
                        }
                    },
                    {
                        id: "support-3",
                        question: {
                            en: "What can I do to have my workplace adapted to my disability?",
                            pt: "O que posso fazer para ter o meu local de trabalho adaptado à minha incapacidade?"
                        },
                        answer: {
                            en: "If you have a disability, you can benefit from support from IEFP, such as the Workplace Adaptation Program. The company can receive technical and financial support to create suitable conditions. You can also request an assessment at the Centros de Recursos para a Inclusão Profissional (Centers for Professional Inclusion), which in Campanhã is located at the Porto Cerebral Palsy Association.",
                            pt: "Se tens uma incapacidade, podes beneficiar de apoios do IEFP, como o Programa de Adaptação de Postos de Trabalho. A empresa pode receber apoio técnico e financeiro para criar condições adequadas. Também pode pedir avaliação nos Centros de Recursos para a Inclusão Profissional que, em Campanhã, encontra-se na Associação do Porto de Paralisia Cerebral."
                        }
                    },
                    {
                        id: "support-4",
                        question: {
                            en: "How can I apply for a funded internship?",
                            pt: "Como posso candidatar-me a um estágio financiado?"
                        },
                        answer: {
                            en: "You can apply for funded internships through the IEFP Estágios ATIVAR.PT program. Applications are submitted online, and the support includes an internship allowance, meal allowance, and transportation. Do you need help registering on the portal?",
                            pt: "Podes candidatar-te a estágios financiados através do programa Estágios ATIVAR.PT do IEFP. As candidaturas são feitas online, e o apoio inclui bolsa de estágio, alimentação e transporte. Precisas de ajuda para registar-se no portal?"
                        }
                    },
                    {
                        id: "support-5",
                        question: {
                            en: "I am finishing a course. Where can I do an internship in Campanhã?",
                            pt: "Estou a terminar um curso. Onde posso fazer estágio em Campanhã?"
                        },
                        answer: {
                            en: "You can look for internships in local companies, contact the Parish Council, neighborhood associations, or use the partnership network of your training center. Often, schools or Centros Qualifica already have contacts with organizations in Campanhã.",
                            pt: "Podes procurar estágio em empresas locais, contactar a Junta de Freguesia, associações de bairro ou usar a rede de parcerias do seu centro de formação. Muitas vezes, as escolas ou Centros Qualifica já têm contactos com entidades em Campanhã."
                        }
                    }
                ]
            }
        ]
    },
    integrate: {
        name: {
            en: "Integrate / Belonging",
            pt: "Integração / Pertença"
        },
        subcategories: [
            {
                id: "conversation",
                name: {
                    en: "Improving Conversation Skills",
                    pt: "Melhorar Habilidades de Conversação"
                },
                description: {
                    en: "Language practice",
                    pt: "Prática de idiomas"
                },
                questions: [
                    {
                        id: "conversation-1",
                        question: {
                            en: "Are there meetups in Campanhã to practice Portuguese with others?",
                            pt: "Existem encontros em Campanhã para praticar português com outras pessoas?"
                        },
                        answer: {
                            en: "Yes! In Campanhã, there are informal Portuguese conversation groups organized by local associations, libraries, or community centers. These are safe spaces where you can practice with others in similar situations. Would you like me to provide information about the next meetups?",
                            pt: "Sim! Em Campanhã existem grupos informais de conversação em português, organizados por associações locais, bibliotecas ou centros comunitários. São espaços seguros onde pode praticar com outras pessoas em situação semelhante. Quer que lhe indique onde são os próximos encontros?"
                        }
                    },
                    {
                        id: "conversation-2",
                        question: {
                            en: "Are there free Portuguese courses in Campanhã?",
                            pt: "Há cursos de português gratuitos em Campanhã?"
                        },
                        answer: {
                            en: "Yes. You can find free Portuguese courses for Speakers of Other Languages (PFOL) at: Campanhã Parish Council, Associations such as Espaço T or Casa da Horta, Centros Qualifica or local schools with support from IEFP.",
                            pt: "Sim. Pode encontrar cursos de Português para Falantes de Outras Línguas (PFOL) gratuitos em: Junta de Freguesia de Campanhã, Associações como a Espaço T ou Casa da Horta, Centros Qualifica ou escolas locais com apoio do IEFP."
                        }
                    },
                    {
                        id: "conversation-3",
                        question: {
                            en: "Are there groups for mothers where Portuguese is spoken?",
                            pt: "Há grupos para mães onde se fala português?"
                        },
                        answer: {
                            en: "Yes. There are mother and family groups that organize meetups in Portuguese, often with the support of social centers, daycare centers, or health centers. These groups help with integration, sharing experiences, and practicing the language.",
                            pt: "Sim. Existem grupos de mães e famílias que organizam encontros em português, muitas vezes com o apoio de centros sociais, creches ou centros de saúde. Estes grupos ajudam a integrar, partilhar experiências e praticar a língua."
                        }
                    }
                ]
            },
            {
                id: "shopping",
                name: {
                    en: "Best Places to Shop",
                    pt: "Melhores Lugares para Compras"
                },
                description: {
                    en: "Shopping locations",
                    pt: "Locais de compras"
                },
                questions: [
                    {
                        id: "shopping-1",
                        question: {
                            en: "Where can I find stores with typical products from other countries in Campanhã?",
                            pt: "Onde posso encontrar lojas com produtos típicos de outros países em Campanhã?"
                        },
                        answer: {
                            en: "In Campanhã, there are several stores and grocery shops offering African, Brazilian, Asian, and Eastern European products. They are usually located near Campanhã Station and in areas with greater cultural diversity.",
                            pt: "Em Campanhã, há várias lojas e mercearias com produtos africanos, brasileiros, asiáticos e do leste europeu. Estão geralmente perto da Estação de Campanhã e em zonas com maior diversidade cultural."
                        }
                    }
                ]
            },
            {
                id: "exchange",
                name: {
                    en: "Exchange Markets",
                    pt: "Mercados de Troca"
                },
                description: {
                    en: "Swap markets and second-hand items",
                    pt: "Mercados de troca e itens de segunda mão"
                },
                questions: [
                    {
                        id: "exchange-1",
                        question: {
                            en: "Is there any swap market in Campanhã?",
                            pt: "Há algum mercado de trocas em Campanhã?"
                        },
                        answer: {
                            en: "Yes. Occasionally, swap markets are organized by local associations or community projects, especially in cultural centers and neighborhoods. Campmarket is one of the markets that occasionally hosts a swap market.",
                            pt: "Sim. Ocasionalmente são organizados mercados de trocas (swap markets) por associações locais ou projetos comunitários, especialmente em centros culturais e bairros. O Campmarket é um dos mercados que ocorre ocasionalmente e que recebe mercado de trocas."
                        }
                    },
                    {
                        id: "exchange-2",
                        question: {
                            en: "Is there a traditional market with new or second-hand items?",
                            pt: "Há algum mercado tradicional com artigos usados ou novos?"
                        },
                        answer: {
                            en: "Yes. The Vandoma Market, in Porto, is a great place to find new, used, or second-hand items. There are also local periodic fairs in Campanhã with clothes, utensils, and fresh products. Would you like to know the days and hours?",
                            pt: "Sim. O Mercado de Vandoma, no Porto, é um bom local para encontrar artigos novos, usados ou em segunda mão. Também há feiras locais periódicas em Campanhã com roupas, utensílios e produtos frescos. Gostava de saber os dias e horários?"
                        }
                    }
                ]
            },
            {
                id: "events",
                name: {
                    en: "Fine Events",
                    pt: "Eventos"
                },
                description: {
                    en: "Workshops, festivals, exhibitions",
                    pt: "Workshops, festivais, exposições"
                },
                questions: [
                    {
                        id: "events-1",
                        question: {
                            en: "Are there any theater companies in Campanhã?",
                            pt: "Existem companhias de teatro em Campanhã?"
                        },
                        answer: {
                            en: "Campanhã is an active hub of theatrical creation in Porto, with several local companies and groups energizing the cultural scene of the parish. Visões Úteis: A professional company based in Campanhã since 2020, with strong community involvement. Novo Acto: Another amateur theater group in the area. Era uma Vez… Teatro: An inclusive project aimed at raising awareness of the artistic abilities of people with disabilities.",
                            pt: "Campanhã é um polo ativo de criação teatral no Porto, com várias companhias e grupos locais a dinamizar a cena cultural da freguesia. Visões Úteis: Uma companhia profissional sediada em Campanhã desde 2020, com um forte envolvimento comunitário. Novo Acto: Outro grupo de teatro amador da zona. Era uma vez… Teatro: Um projeto inclusivo que pretende sensibilizar a sociedade para as capacidades artísticas das pessoas com deficiência."
                        }
                    },
                    {
                        id: "events-2",
                        question: {
                            en: "What shows are currently on in Porto?",
                            pt: "Que espetáculos estão atualmente em exibição no Porto?"
                        },
                        answer: {
                            en: "You can check the Porto Cultural Agenda, which provides information about cultural events happening in the city of Porto! Here you can find the latest information about shows and cultural events in the city.",
                            pt: "Podes consultar a Agenda Cultural do Porto, que disponibiliza informações sobre eventos culturais que estão a acontecer na cidade do Porto! Aqui podes encontrar informações mais recentes sobre espetáculos e eventos culturais na cidade."
                        }
                    }
                ]
            },
            {
                id: "religious",
                name: {
                    en: "Religious and Spiritual Places",
                    pt: "Locais Religiosos e Espirituais"
                },
                description: {
                    en: "Places of worship and spiritual communities",
                    pt: "Locais de culto e comunidades espirituais"
                },
                questions: [
                    {
                        id: "religious-1",
                        question: {
                            en: "What religious places and spiritual communities are there in Campanhã?",
                            pt: "Que locais religiosos e comunidades espirituais existem em Campanhã?"
                        },
                        answer: {
                            en: "Campanhã is home to a variety of religious spaces and spiritual communities with strong ties to the local population. Notable ones include: Igreja Paroquial de Campanhã, also known as Santa Maria de Campanhã Church, located on Rua do Falcão, and part of the Diocese of Porto. You can contact them at: 935370340 / campanha@diocese-porto.pt. Centro Cultural Islâmico do Porto (Mesquita Hazrat Bilal). Located at Rua do Heroísmo, 223, this is the main mosque in the city and one of the oldest in northern Portugal. Founded in the 1990s, it currently gathers more than 6,000 people from various nationalities. It offers daily prayers, including Friday prayer (Jumu'ah), and community activities such as Portuguese classes, legal support, and social integration. Hillsong Portugal – Campus Porto. A contemporary church with a focus on music and youth, located at Rua Justino Teixeira, 451-469.",
                            pt: "Campanhã acolhe uma diversidade de espaços religiosos e comunidades espirituais com forte ligação à população local. Destacam-se: Igreja Paroquial de Campanhã, também conhecida como Igreja Santa Maria de Campanhã, está localizada na Rua do Falcão e pertence à Diocese do Porto. Podes contactar através dos seguintes meios: 935370340 / campanha@diocese-porto.pt. Centro Cultural Islâmico do Porto (Mesquita Hazrat Bilal). Localizado na Rua do Heroísmo, 223, esta é a principal mesquita da cidade e uma das mais antigas da região norte de Portugal. Fundada na década de 1990, reúne atualmente mais de 6.000 pessoas de diversas nacionalidades. Oferece orações diárias, incluindo a oração de sexta-feira (Jumu'ah), e atividades comunitárias como aulas de português, apoio jurídico e integração social. Hillsong Portugal – Campus Porto. Uma igreja contemporânea com enfoque na música e na juventude. Situa-se na Rua Justino Teixeira, 451-469."
                        }
                    }
                ]
            },
            {
                id: "parks",
                name: {
                    en: "Gardens, Parks, and Walks",
                    pt: "Jardins, Parques e Passeios"
                },
                description: {
                    en: "Green spaces",
                    pt: "Espaços verdes"
                },
                questions: [
                    {
                        id: "parks-1",
                        question: {
                            en: "What parks or gardens are there in the Campanhã area?",
                            pt: "Que parques ou jardins existem na zona de Campanhã?"
                        },
                        answer: {
                            en: "In Campanhã, you can visit several green spaces, such as: Jardim da Corujeira, Parque de Alameda de Cartes, Parque de São Roque, Parque Oriental da Cidade do Porto – one of the largest and most beautiful in the area, ideal for walks and picnics. Would you like me to provide directions on how to get there?",
                            pt: "Em Campanhã, podes visitar vários espaços verdes, como: Jardim da Corujeira, Parque de Alameda de Cartes, Parque de São Roque, Parque Oriental da Cidade do Porto – um dos maiores e mais bonitos da zona, ideal para caminhadas e piqueniques. Quer que lhe indique como lá chegar?"
                        }
                    },
                    {
                        id: "parks-2",
                        question: {
                            en: "Are the parks or gardens in Campanhã accessible to people with reduced mobility?",
                            pt: "Os parques ou jardins de Campanhã são acessíveis a pessoas com mobilidade condicionada?"
                        },
                        answer: {
                            en: "Yes, several parks have adapted access, such as ramps, wide paths, and flat areas. Parque Alameda de Cartes and Parque Oriental have good conditions for wheelchairs or strollers. I can confirm specific access details if you want to visit one of them.",
                            pt: "Sim, vários parques têm acessos adaptados, como rampas, caminhos largos e zonas planas. O Parque Alameda de Cartes e o Parque Oriental têm boas condições para cadeiras de rodas ou carrinhos de bebé. Posso confirmar acessos específicos se quiser visitar um deles."
                        }
                    },
                    {
                        id: "parks-3",
                        question: {
                            en: "What walkways or trails are there in Campanhã?",
                            pt: "Que passadiços ou roteiros existem em Campanhã?"
                        },
                        answer: {
                            en: "Campanhã has several pedestrian routes, including: The Passadiço do Parque Oriental, along the Rio Tinto, Yoga Walks, promoted by the Associação Jardim do Yoga. Would you like a map of the routes?",
                            pt: "Campanhã tem vários percursos pedonais, incluindo: O Passadiço do Parque Oriental, junto ao Rio Tinto, Caminhadas com Yoga, promovido pela Associação Jardim do Yoga. Quer um mapa com os roteiros?"
                        }
                    }
                ]
            },
            {
                id: "sports",
                name: {
                    en: "Places to Play Sports",
                    pt: "Lugares para Praticar Esportes"
                },
                description: {
                    en: "Sports facilities",
                    pt: "Instalações desportivas"
                },
                questions: [
                    {
                        id: "sports-1",
                        question: {
                            en: "What sports clubs are there in Campanhã?",
                            pt: "Que clubes desportivos existem em Campanhã?"
                        },
                        answer: {
                            en: "There are several sports clubs in the area, such as: Sport Comércio e Salgueiros, Iniciação Desportiva de São Roque.",
                            pt: "Existem vários clubes desportivos na zona, como: Sport Comércio e Salgueiros, Iniciação Desportiva de São Roque."
                        }
                    },
                    {
                        id: "sports-2",
                        question: {
                            en: "What sports activities can be found in Campanhã?",
                            pt: "Que atividades desportivas é possível encontrar em Campanhã?"
                        },
                        answer: {
                            en: "You can find activities such as: Football, karate, dance, gymnastics, yoga, athletics, and guided walks. Classes in schools, local gyms, and community centers. Outdoor activities in parks. Would you like to know where you can sign up for a free activity?",
                            pt: "Podes encontrar atividades como: Futebol, karaté, dança, ginástica, yoga, atletismo e caminhadas orientadas. Aulas em escolas, ginásios locais e centros comunitários. Atividades ao ar livre nos parques. Gostava de saber onde se pode inscrever numa atividade gratuita?"
                        }
                    }
                ]
            }
        ]
    }
};
document.addEventListener('DOMContentLoaded', function () {
    // Current language (default: English)
    let currentLanguage = 'en';

    // Current state
    let currentCategory = null;
    let currentSubcategory = null;

    // Get DOM elements
    const categoryItems = document.querySelectorAll('.category-item');
    const subcategoriesDiv = document.getElementById('subcategories');
    const chatMessagesDiv = document.getElementById('chat-messages');

    // Function for smooth scrolling to chat area
    function scrollToChatAnswer() {
        if (chatMessagesDiv) {
            chatMessagesDiv.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        }
    }

    // Function to scroll to the entire chat area
    function scrollToChatArea() {
        const chatArea = document.querySelector('.chat-area');
        if (chatArea) {
            chatArea.scrollIntoView({
                behavior: 'smooth',
                block: 'center'
            });
        }
    }

    // Add click event listeners to each category item
    categoryItems.forEach(item => {
        item.addEventListener('click', function () {
            // Remove active class from all category items
            categoryItems.forEach(cat => cat.classList.remove('active'));

            // Add active class to clicked item
            this.classList.add('active');

            // Get the category from data attribute
            const category = this.getAttribute('data-category');
            currentCategory = category;
            currentSubcategory = null;

            // Show subcategories for this category
            showSubcategories(category);

            // Clear chat messages
            chatMessagesDiv.innerHTML = '';
        });
    });

    // Function to show subcategories for a selected category
    function showSubcategories(category) {
        const categoryData = chatbotData[category];
        if (!categoryData) return;

        const lang = currentLanguage;

        let html = `
            <p>Let's find the right educational support for you.</p>
            <p>Are you looking for:</p>
            <div class="response-options">
        `;

        categoryData.subcategories.forEach(subcategory => {
            html += `
                <div class="response-option" data-subcategory="${subcategory.id}">
                    <h4>${subcategory.name[lang]}</h4>
                    <p>${subcategory.description[lang]}</p>
                </div>
            `;
        });

        html += `</div>`;

        subcategoriesDiv.innerHTML = html;

        // Add click event listeners to subcategory items
        const subcategoryItems = document.querySelectorAll('.response-option');
        subcategoryItems.forEach(item => {
            item.addEventListener('click', function () {
                const subcategoryId = this.getAttribute('data-subcategory');
                currentSubcategory = subcategoryId;
                showQuestions(category, subcategoryId);
            });
        });
    }

    // Function to show questions for a selected subcategory
    function showQuestions(category, subcategoryId) {
        const categoryData = chatbotData[category];
        if (!categoryData) return;

        const subcategory = categoryData.subcategories.find(sub => sub.id === subcategoryId);
        if (!subcategory) return;

        const lang = currentLanguage;

        let html = `
            <button class="back-button" onclick="backToSubcategories()">
                <i class="fas fa-arrow-left"></i> Back
            </button>
            <h3>${subcategory.name[lang]}</h3>
            <p>Select a question:</p>
            <div class="questions-list">
        `;

        subcategory.questions.forEach(question => {
            html += `
                <div class="question-item" data-question="${question.id}">
                    <p>${question.question[lang]}</p>
                </div>
            `;
        });

        html += `</div>`;

        subcategoriesDiv.innerHTML = html;

        // Add click event listeners to question items
        const questionItems = document.querySelectorAll('.question-item');
        questionItems.forEach(item => {
            item.addEventListener('click', function () {
                const questionId = this.getAttribute('data-question');
                showAnswer(category, subcategoryId, questionId);

                // Scroll to chat area when question is clicked
                setTimeout(() => {
                    scrollToChatArea();
                }, 200);
            });
        });
    }

    // Function to show answer for a selected question (UPDATED WITH SCROLLING)
    function showAnswer(category, subcategoryId, questionId) {
        const categoryData = chatbotData[category];
        if (!categoryData) return;

        const subcategory = categoryData.subcategories.find(sub => sub.id === subcategoryId);
        if (!subcategory) return;

        const question = subcategory.questions.find(q => q.id === questionId);
        if (!question) {
            return;
        }

        const lang = currentLanguage;

        addMessage('user', question.question[lang]);
        addTypingIndicator();

        // Scroll to chat area immediately after user message
        setTimeout(() => {
            scrollToChatAnswer();
        }, 100);

        setTimeout(() => {
            removeTypingIndicator();
            addMessage('bot', question.answer[lang]);

            // Scroll again after bot response is added
            setTimeout(() => {
                scrollToChatAnswer();
            }, 100);
        }, 3000);
    }

    // Function to add a message to the chat (UPDATED WITH AUTO-SCROLL)
    function addMessage(role, content) {
        const messageDiv = document.createElement('div');
        messageDiv.className = `message ${role}-message`;
        messageDiv.textContent = content;

        chatMessagesDiv.appendChild(messageDiv);

        // Auto-scroll to the latest message
        setTimeout(() => {
            chatMessagesDiv.scrollTop = chatMessagesDiv.scrollHeight;
        }, 50);
    }

    // Function to go back to subcategories
    window.backToSubcategories = function () {
        if (currentCategory) {
            showSubcategories(currentCategory);
        }
    };

    // Function to add typing indicator
    function addTypingIndicator() {
        const typingDiv = document.createElement('div');
        typingDiv.className = 'message bot-message typing-indicator';
        typingDiv.innerHTML = '<span></span><span></span><span></span>'; // Typing dots

        chatMessagesDiv.appendChild(typingDiv);

        // Scroll to the bottom of the chat
        chatMessagesDiv.scrollTop = chatMessagesDiv.scrollHeight;
    }

    // Function to remove typing indicator
    function removeTypingIndicator() {
        const typingDiv = document.querySelector('.typing-indicator');
        if (typingDiv) {
            typingDiv.remove();
        }
    }

    // Set Live as the default selected category
    const liveCategory = document.querySelector('[data-category="live"]');
    if (liveCategory) {
        liveCategory.click();
    }
});

